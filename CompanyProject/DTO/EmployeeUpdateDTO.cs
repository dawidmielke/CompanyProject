using System.ComponentModel.DataAnnotations;

namespace CompanyProject.DTO
{
    public class EmployeeUpdateDTO
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

        public string? Password { get; set; }

        public string Role { get; set; }

        public IFormFile? Image { get; set; }
    }
}
