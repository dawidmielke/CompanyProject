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
        private readonly ApplicationDbContext context;

        public TaskController(ITaskRepository taskRepository, ApplicationDbContext context)
        {
            this.taskRepository = taskRepository;
            this.context = context;
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
                return RedirectToAction("Index", "Task");

            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var task = context.EmployeeTasks.Find(id);
            if(task == null)
            {
                return NotFound("Task not found");
            }
            
            var model = new TaskEditViewModel
            {
                TaskName = task.TaskName,
                TaskDescription = task.TaskDescription,
                TaskStart = task.TaskStart,
                TaskEnd = task.TaskEnd
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, TaskEditViewModel model)
        {
            var task = context.EmployeeTasks.Find(id);
            if (task == null)
            {
                return NotFound("Task not found");
            }

            if (ModelState.IsValid)
            {
                task.TaskName = model.TaskName;
                task.TaskDescription = model.TaskDescription;
                task.TaskStart = model.TaskStart;
                task.TaskEnd = model.TaskEnd;
                context.SaveChanges();
                return RedirectToAction("Index", "Task");
            }
            return View(model);
        }

        public IActionResult Details(int id) // string id 
        {
            var task = context.EmployeeTasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }
            return View("Details");
        }


        public IActionResult Delete(int id)
        {
            var task = taskRepository.Get(id);
            if (task == null)
            {
                return NotFound();
            }
            taskRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
