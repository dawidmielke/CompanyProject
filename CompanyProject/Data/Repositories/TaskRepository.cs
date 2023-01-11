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
