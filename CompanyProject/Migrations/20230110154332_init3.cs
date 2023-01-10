using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "ALmc4uw816/MAVnsdl7TYqkYYolPBizazpZSkYJwkNKexxNWuqsf8ygvXMjseBM6pw==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "AC2zL98CUeACiGa5qkiBcLufaXLbb4IgoYRBwR0eYlcVww7OJHCK70SoaqSMA/rudw==");
        }
    }
}
