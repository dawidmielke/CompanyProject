using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyProject.Data.Models
{
    public class EmployeeLeave
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string LeaveDescription { get; set; }
        public DateTime LeaveStart { get; set; }
        public DateTime LeaveEnd { get; set; }

        public Employee Employee { get; set; }

    }
}
