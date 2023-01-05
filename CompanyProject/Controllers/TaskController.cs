using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CompanyProject.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext context;

        public TaskController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(context.EmployeeTasks.Where(task => task.EmployeeId == userId).ToList());
        }

        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TaskViewModel model)
        {
            if(ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                EmployeeTask user = new EmployeeTask
                {
                    TaskDescription = model.TaskDescription,
                    TaskEnd = model.TaskEnd,
                    TaskStart = model.TaskStart,
                    TaskName = model.TaskName,
                    EmployeeId = userId
                };

                context.EmployeeTasks.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(model);
        }
    }
}
