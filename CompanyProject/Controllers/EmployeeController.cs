using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.DTO;
using CompanyProject.Services;
using CompanyProject.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly IEmployeeService employeeService;

        public EmployeeController(ApplicationDbContext context, UserManager<Employee> userManager, IEmployeeService employeeService)
        {
            this.context = context;
            this.userManager = userManager;
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Users.Select(x => new EmployeeGetDTO
            {
                Id = x.Id,
                Birth = x.Birth,
                Email = x.Email,
                Image = x.Image,
                Name = x.Name,
                Surname = x.Surname
            }).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(context.Users.Select(x => new EmployeeGetDTO
            {
                Id = x.Id,
                Birth = x.Birth,
                Email = x.Email,
                Image = x.Image,
                Name = x.Name,
                Surname = x.Surname
            }).FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateDTO model)
        {
            if (ModelState.IsValid)
            {

                Employee user = new Employee
                {
                    Email = model.Email,
                    UserName = model.Email,
                    Surname = model.Surname,
                    Name = model.Name,
                    Birth = model.Birth,
                };

                (bool success, string message) = employeeService.AddEmployee(user, model.Password, model.Image, model.Role);
                if (success)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Adding error: " + message);
                }
            }

            return BadRequest("Invalid data in the query");
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, EmployeeUpdateDTO model)
        {
            var employee = context.Users.Find(id);
            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            if (ModelState.IsValid)
            {
                employee.Surname = model.Surname;
                employee.Name = model.Name;
                employee.Birth = model.Birth;
                employee.Email = model.Email;

                (bool success, string message) = employeeService.EditEmployee(id, employee, model.Password, model.Image, model.Role);
                if(success)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Edit error: " + message);
                }
            }

            return BadRequest("Invalid query data");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var employee = context.Users.Find(id);
            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            var success = userManager.DeleteAsync(employee).Result.Succeeded;
            if(success)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Deletion error");
            }
        }
    }
}
