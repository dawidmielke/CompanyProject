using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProject.Controllers
{
    public class LeaveController : Controller
    {
        public IActionResult AddLeave()
        {
            return View();
        }

        public IActionResult AddLeave(LeaveViewModel model)
        {
            if (ModelState.IsValid)
            {
                EmployeeLeave leave = new EmployeeLeave
                {
                    LeaveDescription = model.LeaveDescription,
                    LeaveStart = model.LeaveStart,
                    LeaveEnd = model.LeaveEnd
                };
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
