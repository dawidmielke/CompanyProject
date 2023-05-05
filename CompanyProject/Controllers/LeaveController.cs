using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> AddLeave(LeaveViewModel model)
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
                return RedirectToAction("Index", "Leave");
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var leave = await context.EmployeeLeave.FindAsync(id);

            if (leave == null)
            {
                return NotFound("Leave not found");
            }

            var model = new LeaveEditViewModel
            {
                LeaveDescription = leave.LeaveDescription,
                LeaveStart = leave.LeaveStart,
                LeaveEnd = leave.LeaveEnd
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, LeaveEditViewModel model)
        {
            var leave = await context.EmployeeLeave.FindAsync(id);
            if (leave == null)
            {
                return NotFound("leave not found");
            }

            if (ModelState.IsValid)
            {
                leave.LeaveDescription = model.LeaveDescription;
                leave.LeaveEnd = model.LeaveEnd;
                leave.LeaveStart = model.LeaveStart;
                context.SaveChanges();
                return RedirectToAction("Index", "Leave");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var leave = await context.EmployeeLeave.FirstOrDefaultAsync(x => x.Id == id);
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
