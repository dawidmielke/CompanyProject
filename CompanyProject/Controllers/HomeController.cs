using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Models;
using CompanyProject.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CompanyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Employee> userManager;
        private readonly ApplicationDbContext context;
        private readonly ITaskRepository taskRepository;

        public HomeController(ILogger<HomeController> logger, UserManager<Employee> userManager, ApplicationDbContext context, ITaskRepository taskRepository)
        {
            _logger = logger;
            this.userManager = userManager;
            this.context = context;
            this.taskRepository = taskRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Employees(string SearchString)
        {
            var employee = from m in context.Users
                           select m;
            if (!string.IsNullOrEmpty(SearchString)) 
            {
                employee = employee.Where(x => x.Name!.Contains(SearchString));
            }

            return View(employee.ToList());
        }

        //[Authorize(Roles = "Administrator")]
        //public IActionResult Employees(string SearchString)
        //{
        //    var employee = from m in context.Users
        //                   select m;
        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        employee = employee.Where(x => x.Surname!.Contains(SearchString));
        //    }

        //    return View(employee.ToList());
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteUser(string id)
        {
            var employee = context.Users.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            userManager.DeleteAsync(employee).Wait();

            return RedirectToAction("Employees");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult EditEmployee(string id)
        {
            var employee = context.Users.Find(id);
            if (employee == null)
            {
                return NotFound("Employee not found");
            }
            var model = new EmployeeEditViewModel
            {
                Birth = employee.Birth.Value,
                Email = employee.Email,
                Name = employee.Name,
                Surname = employee.Surname,
            };
            var roles = userManager.GetRolesAsync(employee).Result;
            if(roles.Count() > 0)
            {
                model.Role = roles[0];
            }

            return View(model);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult EditEmployee(string id, EmployeeEditViewModel model)
        {
            var employee = context.Users.Find(id);
            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            if(ModelState.IsValid)
            {
                employee.Surname = model.Surname;
                employee.Name = model.Name;
                employee.Birth = model.Birth;
                employee.Email = model.Email;

                if(!string.IsNullOrEmpty(model.Password))
                {
                    employee.PasswordHash = PasswordUtil.HashPassword(model.Password);
                }


                if(model.Image != null)
                {
                    employee.Image = ImageUtil.ToBase64Image(model.Image);
                }

                var roles = userManager.GetRolesAsync(employee).Result;
                if (roles.Count() > 0)
                {
                    var role = roles[0];
                    if (role != model.Role)
                    {
                        userManager.RemoveFromRoleAsync(employee, roles[0]).Wait();
                        userManager.AddToRoleAsync(employee, model.Role).Wait();

                    }
                }
                else
                {
                    userManager.AddToRoleAsync(employee, model.Role).Wait();
                }

                context.SaveChanges();
                return RedirectToAction("Employees", "Home");   
            }

            return View(model);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Details(string id)
        {
            var employee = context.Users.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            List<TaskSummaryViewModel> tasksSummary = taskRepository
                .GetTasksByEmployeeId(id)
                .OrderBy(x => x.TaskStart)
                .GroupBy(x => x.TaskStart.ToShortDateString())
                .Select(g => new TaskSummaryViewModel {Date=g.Key, Hours=g.Sum(x => (x.TaskEnd - x.TaskStart).TotalHours)  })
                .ToList();

            ViewBag.TasksSummary = JsonConvert.SerializeObject(tasksSummary);

            return View(employee);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public IActionResult AddEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee user = new Employee
                {
                    Email = model.Email,
                    UserName = model.Email,
                    Surname = model.Surname,
                    Name = model.Name,
                    Birth = model.Birth,
                    Image = ImageUtil.ToBase64Image(model.Image)
                };
                userManager.CreateAsync(user, model.Password).Wait();
                userManager.AddToRoleAsync(user, model.Role).Wait();
                return RedirectToAction("Employees", "Home");
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}