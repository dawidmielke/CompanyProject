using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyProject.Data.Models
{
    public class EmployeeTask
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
    }
}
