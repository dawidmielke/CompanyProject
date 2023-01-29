using CompanyProject.Data.Models;


namespace CompanyProject.Data.Repositories
{
    public class TaskMockRepository
    {
        private readonly List<EmployeeTask> tasks;

        public TaskMockRepository()
        {
            tasks = new List<EmployeeTask>();
        }

        public void Create(EmployeeTask employeeTask)
        {
            tasks.Add(employeeTask);
        }

        public void Delete(int id)
        {
            var task = Get(id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        public EmployeeTask Get(int id)
        {
            return tasks.FirstOrDefault(x => x.Id == id);
        }

        public List<EmployeeTask> GetAll()
        {
            return tasks.ToList();
        }

        public List<EmployeeTask> GetTasksByEmployeeId(string id)
        {
            return tasks.Where(x => x.EmployeeId == id).ToList();
        }

        public void Update(EmployeeTask employeeTask)
        {
            var task = Get(employeeTask.Id);
            if(task != null)
            {
                task.TaskStart = employeeTask.TaskStart;
                task.TaskEnd = employeeTask.TaskEnd;
                task.TaskName = employeeTask.TaskName;
                task.TaskDescription = employeeTask.TaskDescription;
                task.EmployeeId = employeeTask.EmployeeId;
                task.Employee = task.Employee;
            }
        }
    }
}
