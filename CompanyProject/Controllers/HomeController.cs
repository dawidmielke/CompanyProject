using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Interfaces;
using CompanyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

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

        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Employees(string id)
        {
            var employee = from m in context.Users
                           select m;
            if (!String.IsNullOrEmpty(id)) 
            {
                employee = employee.Where(x => x.Name!.Contains(id));
            }

            return View(await employee.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[Authorize(Roles = "Administrator")]
        //public IActionResult Employees()
        //{
        //    return View(context.Users.ToList());
        //}


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

        //public IActionResult Edit(string id)
        //{
        //    var employee = context.Users.Find(id);
        //    if(employee == null)
        //    {
        //        return NotFound();
        //    }

        //    var employee = new EditEmployeeViewModel
        //    {

        //    }
        //}

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
                string base64img = null;
                if (model.Image != null && model.Image.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        model.Image.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        base64img = Convert.ToBase64String(fileBytes);
                    }
                }

                Employee user = new Employee
                {
                    Email = model.Email,
                    UserName = model.Email,
                    Surname = model.Surname,
                    Name = model.Name,
                    Birth = model.Birth,
                    Image = base64img
                };
                userManager.CreateAsync(user, model.Password).Wait();
                userManager.AddToRoleAsync(user, model.Role).Wait();
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