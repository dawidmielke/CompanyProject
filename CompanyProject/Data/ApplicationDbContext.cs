using CompanyProject.Data.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace CompanyProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole[]
            {
                new IdentityRole{ 
                    Id = "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41", 
                    Name="Administrator", 
                    NormalizedName="Administrator".ToUpper(),
                    //ConcurrencyStamp = "93471d69-4b83-43e9-bce0-f5c4f1c1e649"
                },
                new IdentityRole{
                    Id = "33244a2a-62a8-4f91-83ac-6435a1348629",
                    Name="User",
                    NormalizedName="User".ToUpper(),
                    //ConcurrencyStamp = "1d51ee3b-d24f-4aae-b883-aa84051a1f06"
                }
            });

            builder.Entity<Employee>().HasData(new Employee[]
            {
                new Employee{ 
                    Birth = new DateTime(2023, 1, 5),
                    Email = "admin@company.pl",
                    UserName = "admin@company.pl",
                    ConcurrencyStamp = "6a045f02-029a-484a-a2fb-22e0fd9f55af",
                    Name = "Admin",
                    Surname = "Admin",
                    NormalizedEmail =  "ADMIN@COMPANY.PL",
                    NormalizedUserName = "ADMIN@COMPANY.PL",
                    Image = "iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAARElEQVR42u3PMREAAAgEIE1u9DeDqwcN6KSmHmgRERERERERERERERERERERERERERERERERERERERERERERERERkYsFnhx8ndlgmS8AAAAASUVORK5CYII=",
                    EmailConfirmed = true,
                    Id = "4808c606-89cf-4a92-8ff6-33074a34a335",
                    PasswordHash = HashPassword("Admin1234")
                }
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string> {UserId="4808c606-89cf-4a92-8ff6-33074a34a335", RoleId="40c6bc97-f08f-41e4-bf60-ccd30ff4ab41"}
            });
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    



    public DbSet<EmployeeTask> EmployeeTasks { get; set; }

    public DbSet<CompanyProject.Data.Models.EmployeeLeave> EmployeeLeave { get; set; }
    }
}