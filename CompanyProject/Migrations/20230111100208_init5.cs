using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "AspNetUsers",
                newName: "Image");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "15a937d8-d43c-47a3-a5e0-695cfdca8c28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "12e2b70f-3f02-47e9-8253-4ffecc3a8f52");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "ALrp4kBfnjDsqiu/MFJ/uUglw13qTyt1lbAQXwJVGaUyNoxGC0/045pnNxBd52FDyw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "AspNetUsers",
                newName: "PictureUrl");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "3dfdde93-320f-4255-afc5-2d4847da1e75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "b1c45479-e24c-44f1-9890-074c0145ae77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "ACUmMcuaWCPnyg4a+Q65Sfpvk5jD9fWAohl0JWihaezZ1gK9GdjW/AdIAPNDo74Abg==");
        }
    }
}
