using Microsoft.AspNetCore.Identity;

namespace CompanyProject.Data.Models
{
    public class Employee : IdentityUser
    {
        public DateTime Birth { get; set; }
        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
