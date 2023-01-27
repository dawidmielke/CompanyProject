using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyProject.Data.Models
{
    public class EmployeeLeave
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Leave Description")]
        public string LeaveDescription { get; set; }
        
        [Display(Name = "Leave Start")]
        public DateTime LeaveStart { get; set; }

        [Display(Name = "Leave End")]
        public DateTime LeaveEnd { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }

    }
}
