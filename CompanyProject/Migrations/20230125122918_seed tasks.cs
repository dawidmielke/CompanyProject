using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class seedtasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "c883379c-8157-4b1c-bf18-b7b09db294a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "7c507296-d57c-462e-84e1-8c3be32232f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "ANwxoeuwgFfc8PZWqYVbK8AitnBkEWIQ0iAz1tyGgJ77rQBOH8//WFRfM+BF1ZmJ9w==", "6f4a8c27-e463-4ba5-a179-661849928444" });

            migrationBuilder.InsertData(
                table: "EmployeeTasks",
                columns: new[] { "Id", "EmployeeId", "TaskDescription", "TaskEnd", "TaskName", "TaskStart" },
                values: new object[] { 1, "4808c606-89cf-4a92-8ff6-33074a34a335", "Sprawdzic panel admina", new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "Panel admina", new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "d31f196d-eaef-42b9-950d-961b7f14e727");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "e1f9a64f-5875-4c24-becc-4cfe62482f15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AD0KOZSWnkk0djA76nD8rY+IQDcGqEE3BbuoyUjkkNACzYaxExGzoHd3mvOKot+fKg==", "e4040cfe-aa94-4d38-b496-73652aeea3fc" });
        }
    }
}
