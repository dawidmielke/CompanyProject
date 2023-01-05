using Microsoft.AspNetCore.Mvc;

namespace CompanyProject.Controllers
{
    public class AddTasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
