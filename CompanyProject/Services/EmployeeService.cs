using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Tools;
using Microsoft.AspNetCore.Identity;

namespace CompanyProject.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly UserManager<Employee> userManager;
        private readonly ApplicationDbContext context;

        public EmployeeService(UserManager<Employee> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public (bool, string) AddEmployee(Employee employee, string? password, IFormFile? image = null, string? role=null)
        {
            string base64img = null;
            if (image != null && image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    base64img = Convert.ToBase64String(fileBytes);
                }
            }

            employee.Image = base64img;
            userManager.CreateAsync(employee, password).Wait();
            userManager.AddToRoleAsync(employee, role).Wait();
            return (true, "Success");
        }

        public (bool, string) EditEmployee(string id, Employee employee, string? password=null, IFormFile? image=null, string? role=null)
        {
            if (!string.IsNullOrEmpty(password))
            {
                employee.PasswordHash = PasswordUtil.HashPassword(password);
            }

            if (image != null && image.Length > 0)
            {
                employee.Image = ImageUtil.ToBase64Image(image);
            }

            if(role != null)
            {
                var roles = userManager.GetRolesAsync(employee).Result;
                if (roles.Count() > 0)
                {
                    var _role = roles[0];
                    if (_role != role)
                    {
                        userManager.RemoveFromRoleAsync(employee, roles[0]).Wait();
                        userManager.AddToRoleAsync(employee, role).Wait();
                    }
                }
                else
                {
                    userManager.AddToRoleAsync(employee, role).Wait();
                }
            }
            context.SaveChanges();
            return (true, "Success");
        }
    }
}
