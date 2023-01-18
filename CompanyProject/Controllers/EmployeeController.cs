using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Administrator")]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;

        public EmployeeController(ApplicationDbContext context, UserManager<Employee> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public List<EmployeeGetDTO> Get()
        {
            return context.Users.Select(x => new EmployeeGetDTO
            {
                Id = x.Id,
                Birth = x.Birth,
                Email = x.Email,
                Image = x.Image,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }

        [HttpGet("{id}")]
        public EmployeeGetDTO Get(string id)
        {
            return context.Users.Select(x => new EmployeeGetDTO
            {
                Id = x.Id,
                Birth = x.Birth,
                Email = x.Email,
                Image = x.Image,
                Name = x.Name,
                Surname = x.Surname
            }).FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public string Create(EmployeeCreateDTO model)
        {
            if(ModelState.IsValid)
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
                return "OK";
            }

            return "Błąd zapytania";
        }
    }
}
