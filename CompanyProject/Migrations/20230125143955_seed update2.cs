using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class seedupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "c4356b46-0419-4119-b69b-99a638f5bc80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "300dd928-a686-4de9-a9d9-bd15665be588");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "ANUtwZVKF/R4SsqMv1c6v+0FALjzduzEI44XcZA/5yRaKcoufmDU6jDbqdo458GBQA==", "059cf870-7c26-45bc-ad07-543878fa8ba7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birth", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f33ce41b-0881-41a9-80cb-7767438fcdcb", 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "5512e543-a88e-4b61-818a-f022f3089187", "dawidmielke.tri@gmail.com", true, "iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAARElEQVR42u3PMREAAAgEIE1u9DeDqwcN6KSmHmgRERERERERERERERERERERERERERERERERERERERERERERERERkYsFnhx8ndlgmS8AAAAASUVORK5CYII=", false, null, "Dawid", "DAWIDMIELKE.TRI@GMAIL.COM", "DAWIDMIELKE.TRI@GMAIL.COM", "AHLBfdEFyhWXWY5pg0awUxhZVRTqDzx4O8u4xdDf121dt08h96slyeoV3XqiM9p2og==", null, false, "331a25de-3483-44d3-887d-d1bcdf6545e1", "Mielke", false, "dawidmielke.tri@gmail.com" });

            migrationBuilder.UpdateData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaveDescription",
                value: "Urlop Admina");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33244a2a-62a8-4f91-83ac-6435a1348629", "f33ce41b-0881-41a9-80cb-7767438fcdcb" });

            migrationBuilder.InsertData(
                table: "EmployeeLeave",
                columns: new[] { "Id", "EmployeeId", "LeaveDescription", "LeaveEnd", "LeaveStart" },
                values: new object[] { 3, "f33ce41b-0881-41a9-80cb-7767438fcdcb", "Urlop Użytkownika", new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EmployeeTasks",
                columns: new[] { "Id", "EmployeeId", "TaskDescription", "TaskEnd", "TaskName", "TaskStart" },
                values: new object[] { 3, "f33ce41b-0881-41a9-80cb-7767438fcdcb", "Sprawdzic panel użytkownika", new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "Panel użytkownika", new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33244a2a-62a8-4f91-83ac-6435a1348629", "f33ce41b-0881-41a9-80cb-7767438fcdcb" });

            migrationBuilder.DeleteData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f33ce41b-0881-41a9-80cb-7767438fcdcb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "28a8e0c3-c483-44ae-b923-0551f2ea1761");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "959a691f-a55b-4d8e-be21-4707a52582b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "ADFbudRv5qwVdpNgEaJWrK26YAp2t/2GcLof9qVUIr6yAPC67bjEjLmJUecXvz3baQ==", "10791223-a6a0-4c77-9226-d6701a66d180" });

            migrationBuilder.UpdateData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaveDescription",
                value: "Sprawdzic panel admina");
        }
    }
}
