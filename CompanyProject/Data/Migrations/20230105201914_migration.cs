using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Data.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "APftp317PjpaYShJN+X2DjUtP19P8zYMmEwOyG4S9+3kNB0DXnDczv2heZrIdlAsBg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                column: "PasswordHash",
                value: "AOk65MMp2EogDLHKc6/TTXqYUbJTyl5IhdQZmSaJmIL28/QcAm0pOLSQECLZfcukCQ==");
        }
    }
}
