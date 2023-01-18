using System.ComponentModel.DataAnnotations;

namespace CompanyProject.DTO
{
    public class EmployeeGetDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Email { get; set; }
        public DateTime? Birth { get; set; }
        public string Image { get; set; }
    }
}
