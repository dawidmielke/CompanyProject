﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyProject.Migrations
{
    public partial class Seedupdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "9848d023-e9b5-4b00-b7a6-f07df6e0213f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "e66159bd-165f-4035-a6e6-72aef720da42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "ADaMrx0YkVtlaeiPdY7yO+aUrXRXf0jp5KM9sc0OjwK2RAkyqCdOkmLDvgH9uL3mdw==", "5213f82f-aa71-4a57-bae4-6ccd95bc0e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3f4a9b-6a9d-4514-9197-64c599ca7cde",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AMKh7Wr1QC5CicITkDxLHoBc2bfZfn3Zov1I1ZREdLR8TP/SiWxEqQrdW7l75qIbaA==", "c9f92f1a-9e66-4a86-9822-96d0bb2c53f0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birth", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0463448f-fe47-41ab-9e99-b0245c4e7e84", 0, new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "5512e543-a88e-4b61-818a-f022f3089187", "ola.nowak@gmail.com", true, "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", false, null, "Dawid", "OLA.NOWAK@GMAIL.COM", "OLA.NOWAK@GMAIL.COM", "AHBtqTyynxRJAAQoNYlyMKQ5knfI38AAmEZcz8w/G6qUFUoeMo4eXoJSitaG2zfvgw==", null, false, "4bddd79e-3bea-4385-a815-4604bb31fa96", "Mielke", false, "ola.nowak@gmail.com" });

            migrationBuilder.UpdateData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaveEnd",
                value: new DateTime(2023, 1, 25, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33244a2a-62a8-4f91-83ac-6435a1348629", "0463448f-fe47-41ab-9e99-b0245c4e7e84" });

            migrationBuilder.InsertData(
                table: "EmployeeLeave",
                columns: new[] { "Id", "EmployeeId", "LeaveDescription", "LeaveEnd", "LeaveStart" },
                values: new object[] { 4, "0463448f-fe47-41ab-9e99-b0245c4e7e84", "Urlop Oli", new DateTime(2023, 2, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EmployeeTasks",
                columns: new[] { "Id", "EmployeeId", "TaskDescription", "TaskEnd", "TaskName", "TaskStart" },
                values: new object[] { 4, "0463448f-fe47-41ab-9e99-b0245c4e7e84", "Dodać migrację oraz update bazy", new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), "Migracja i baza", new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33244a2a-62a8-4f91-83ac-6435a1348629", "0463448f-fe47-41ab-9e99-b0245c4e7e84" });

            migrationBuilder.DeleteData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0463448f-fe47-41ab-9e99-b0245c4e7e84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "421c3b83-a812-4553-8c0a-01161f2c5009");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "933a3e30-85d9-4652-8328-515cddf481ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AJQwW+fj9WzcbTsLaMZElSnY8Gu1THPP+y7o9hj1M8fHDpanoPi8zOfoz7hJbuyXPg==", "9e05f8a5-665f-4b6a-bdb3-c04d77b99a37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3f4a9b-6a9d-4514-9197-64c599ca7cde",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AGBK7q/EPNr+Se44I9zi0MwIJ1dtZZ3XoDB9dKdhSVmVwjfClSpLyZ3iO3n7nbi+Jg==", "66b1148e-3d78-4390-8443-00176489b6de" });

            migrationBuilder.UpdateData(
                table: "EmployeeLeave",
                keyColumn: "Id",
                keyValue: 1,
                column: "LeaveEnd",
                value: new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
