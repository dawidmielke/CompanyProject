using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Models
{
    public class LeaveViewModel
    {
        [Required]
        public string LeaveEmp { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [Required]
        public DateTime LeaveStart { get; set; }

        [Required]
        public DateTime LeaveEnd { get; set; }
    }
}
