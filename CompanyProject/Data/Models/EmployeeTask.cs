using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyProject.Data.Models
{
    public class EmployeeTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Task Start")]
        public DateTime TaskStart { get; set; }

        [Display(Name = "Task End")]
        public DateTime TaskEnd { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
    }
}
