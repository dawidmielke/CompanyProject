using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "d8bb5b3a-3260-4a3d-8c46-d98f0ca2db5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "6f14e664-908d-4f65-a111-f14af1463bcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ADMIN@COMPANY.PL", "AEZPdrs2RwjR53FvrSDL9X2zFMtygK04Czora9+79hYauChjOeUhOo/MhI7nzNuXWQ==", "3388d2ba-630e-4718-b9bf-cc1dee997e1a", "admin@company.pl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "2e48f6ab-c510-4988-adf5-14f4d2cebb6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "538037a0-ddcc-4aec-8fda-6e117e8fc652");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ADMIN", "AFjmgkc7iqdj5LavjLSDTelxWQXrZF9oOkNq0JycsfJsBRc2HKZXcpHYJ71+eNSwYA==", "59e04a1f-19d4-48b3-aeef-726ed22326ed", "Admin" });
        }
    }
}
