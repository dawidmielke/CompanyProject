using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "ae7aa5bc-4119-4205-92cc-5f9434960fc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "94309c79-3520-47b2-bccc-78ccd55e8d04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { "iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAARElEQVR42u3PMREAAAgEIE1u9DeDqwcN6KSmHmgRERERERERERERERERERERERERERERERERERERERERERERERERkYsFnhx8ndlgmS8AAAAASUVORK5CYII=", "AIvHXaVKIaHKCXecaPbq7TsYugI+/BGF8agdncBxSs1XEh6miczveyT+HJ8KbbPK8w==", "7ca010c8-a81c-4a66-a1ce-e7ff111a7b1a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Image", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "AEZPdrs2RwjR53FvrSDL9X2zFMtygK04Czora9+79hYauChjOeUhOo/MhI7nzNuXWQ==", "3388d2ba-630e-4718-b9bf-cc1dee997e1a" });
        }
    }
}
