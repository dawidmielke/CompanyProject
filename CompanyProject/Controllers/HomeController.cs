using CompanyProject.Data.Models;
using CompanyProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompanyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Employee> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<Employee> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel model)
        {
            Employee user = new Employee
            {
                Email = model.Email,
                UserName = model.Email,
                Surname = model.Surname,
                Name = model.Name,
                Birth = model.Birth,
                PictureUrl = model.PictureUrl
            };

            userManager.CreateAsync(user, model.Password).Wait();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}