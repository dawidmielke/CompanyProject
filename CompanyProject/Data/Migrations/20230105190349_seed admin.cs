using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Data.Migrations
{
    public partial class seedadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birth", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4808c606-89cf-4a92-8ff6-33074a34a335", 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a045f02-029a-484a-a2fb-22e0fd9f55af", "admin@company.pl", true, false, null, "Admin", "ADMIN@COMPANY.PL", "ADMIN", "AGEhYqAmmTu5t3P+QyW8jI32JG17zbn4aoNTJHrZVAy1mc3OGm0jKGfJULyNq5rq6A==", null, false, "empty", "2d493259-1296-424c-976f-bcd33e28d8f5", "Admin", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41", "4808c606-89cf-4a92-8ff6-33074a34a335" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41", "4808c606-89cf-4a92-8ff6-33074a34a335" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335");
        }
    }
}
