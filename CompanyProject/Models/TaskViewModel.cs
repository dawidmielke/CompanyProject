using Microsoft.Build.Framework;

namespace CompanyProject.Models
{
    public class TaskViewModel
    {
        [Required]
        public string TaskName { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [Required]
        public DateTime TaskStart { get; set; }

        [Required]
        public DateTime TaskEnd { get; set; }

    }
}
