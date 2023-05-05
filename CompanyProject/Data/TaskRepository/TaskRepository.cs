using CompanyProject.Data.Models;

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
            var task = GetAsync(id);
            if(task != null)
            {
                context.Remove(task);
                context.SaveChanges();
            }
        }

        public async Task<EmployeeTask> GetAsync(int id)
        {
            var employeeTask = await context.EmployeeTasks.FindAsync(id);
            return employeeTask;
        }

        public List<EmployeeTask> GetAll()
        {
            return context.EmployeeTasks.ToList();
        }

        public List<EmployeeTask> GetTasksByEmployeeId(string id)
        {
            return context.EmployeeTasks.Where(x => x.EmployeeId == id).ToList();
        }

        public void Update(EmployeeTask employeeTask)
        {
            context.Update(employeeTask);
            context.SaveChanges();
        }
    }
}
