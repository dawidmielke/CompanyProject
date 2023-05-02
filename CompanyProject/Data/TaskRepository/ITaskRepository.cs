using CompanyProject.Data.Models;

namespace CompanyProject.Data.Repositories
{
    public interface ITaskRepository
    {
        List<EmployeeTask> GetAll();
        Task<EmployeeTask>? Get(int id);
        void Create(EmployeeTask employeeTask);
        void Update(EmployeeTask employeeTask);
        void Delete(int id);
        List<EmployeeTask> GetTasksByEmployeeId(string id);
    }
}
