using CompanyProject.Data.Models;

namespace CompanyProject.Services
{
    public interface IEmployeeService
    {
        (bool, string) AddEmployee(Employee employee, string? password = null, IFormFile? image = null, string? role = null);
        (bool, string) EditEmployee(string id, Employee employee, string? password = null, IFormFile? image = null, string? role = null);
    }
}
