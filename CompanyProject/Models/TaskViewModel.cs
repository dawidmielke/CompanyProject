using Microsoft.Build.Framework;

namespace CompanyProject.Models
{
    public class TaskViewModel
    {
        [Required]
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }

    }
}
