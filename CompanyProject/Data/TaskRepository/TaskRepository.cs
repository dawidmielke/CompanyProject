using CompanyProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyProject.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext context;

        public TaskRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(EmployeeTask employeeTask)
        {
            context.Add(employeeTask);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = Get(id);
            if(task != null)
            {
                context.Remove(task);
                context.SaveChanges();
            }
        }

        public EmployeeTask Get(int id)
        {
            return context.EmployeeTasks.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<EmployeeTask>> GetAll()
        {
            var employeeTasks =  await context.EmployeeTasks.ToListAsync();
            return employeeTasks;
        }

        public async  Task<List<EmployeeTask>> GetTasksByEmployeeId(string id)
        {
            var taskByEmployeeID = await context.EmployeeTasks.Where(x => x.EmployeeId == id).ToListAsync();
            return taskByEmployeeID;
        }

        public void Update(EmployeeTask employeeTask)
        {
            context.Update(employeeTask);
            context.SaveChanges();
        }
    }
}
