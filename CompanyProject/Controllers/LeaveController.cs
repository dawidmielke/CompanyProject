using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CompanyProject.Controllers
{
    [Authorize]
    public class LeaveController : Controller
    {
        private readonly ApplicationDbContext context;

        public LeaveController(ApplicationDbContext context)
        {
            this.context = context;
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public IActionResult Index()
        {
            string userId = GetUserId();
            return View(context.EmployeeLeave.Where(x => x.EmployeeId == userId).ToList());
        }

        public IActionResult AddLeave()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLeave(LeaveViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeLeave leave = new EmployeeLeave
                {
                    LeaveDescription = model.LeaveDescription,
                    LeaveStart = model.LeaveStart,
                    LeaveEnd = model.LeaveEnd,
                    EmployeeId = GetUserId()
                };
                context.Add(leave);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Details(int id) // string id 
        {
            var leave = context.EmployeeLeave.Find(id);

            if (leave == null)
            {
                return NotFound();
            }
            return View("Details");
        }

        public IActionResult Delete(int id)
        {
            var leave = context.EmployeeLeave.FirstOrDefault(x => x.Id == id);
            if (leave == null)
            {
                return NotFound();
            }
            context.Remove(leave);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
