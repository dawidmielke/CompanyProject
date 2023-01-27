using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CompanyProject.Models
{
    public class LeaveEditViewModel
    {
        [Required]
        [Display(Name = "Leave Description")]
        public string LeaveDescription { get; set; }

        [Required]
        [Display(Name = "Leave Start")]
        public DateTime LeaveStart { get; set; }

        [Required]
        [Display(Name = "Leave End")]
        public DateTime LeaveEnd { get; set; }
    }
}
