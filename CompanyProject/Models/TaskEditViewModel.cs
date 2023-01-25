using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CompanyProject.Models
{
    public class TaskEditViewModel
    {
        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Required]
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        [Required]
        [Display(Name = "Task Start")]
        public DateTime TaskStart { get; set; }

        [Required]
        [Display(Name = "Task End")]
        public DateTime TaskEnd { get; set; }

    }
}
