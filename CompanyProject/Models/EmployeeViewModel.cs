using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public DateTime Birth { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        public string Password { get; set; }

        public string? PictureUrl { get; set; }
    }
}
