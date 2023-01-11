using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
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
        private readonly ITaskRepository taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public IActionResult Index()
        {
            return View(taskRepository.GetTasksByEmployeeId(GetUserId()));
        }

        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeTask task = new EmployeeTask
                {
                    TaskDescription = model.TaskDescription,
                    TaskEnd = model.TaskEnd,
                    TaskStart = model.TaskStart,
                    TaskName = model.TaskName,
                    EmployeeId = GetUserId()
                };

                taskRepository.Create(task);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
