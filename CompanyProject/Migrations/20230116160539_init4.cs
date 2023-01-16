using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeLeave",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeave", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EmployeeLeave_AspNetUsers_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "757b33c1-931f-48d4-b872-9baf016fd8dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "da4461ff-644d-4423-8d07-007472743fcc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "ALggE1zUo1CmGZccjGrdZ4wmqcNoCKQz8XqMXdiIp/BvXDf5GXQOexDpzC2xxyWROw==", "4b614296-a4bd-4d0a-9fd5-0c7ad042f070" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeave_EmployeeId1",
                table: "EmployeeLeave",
                column: "EmployeeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLeave");

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
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AIvHXaVKIaHKCXecaPbq7TsYugI+/BGF8agdncBxSs1XEh6miczveyT+HJ8KbbPK8w==", "7ca010c8-a81c-4a66-a1ce-e7ff111a7b1a" });
        }
    }
}
