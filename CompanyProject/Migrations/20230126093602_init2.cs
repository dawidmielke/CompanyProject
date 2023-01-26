using System;
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
                value: "7ccff884-1cef-4960-9669-5143a32485fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "4e4287c8-ff25-4b86-ba7d-0e2f27df2f63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0463448f-fe47-41ab-9e99-b0245c4e7e84",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AIemy31/6GPHEdTPhv22yCgPcZkJKzLwWGFHxKBF4IOni2+qgFYvO/LNB4Y0188OQA==", "a00f446e-88bc-4841-9a98-8d69ddbbbbf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AI4fH8LeGdHooN2ljK86dGVLcwJ+R76VSKLENsMZ8/9bMpGCCPmJfl1fBzY2xFS4eg==", "575fe4f9-15a7-484e-8a3b-c8a64a5103ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3f4a9b-6a9d-4514-9197-64c599ca7cde",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AGcO0gwYob49V1kukUaoKn/GTK49ypDx/SbHORIC6ENDWFKMaMywOY5u5OtqMmGDXg==", "7113d581-e31a-47e2-9708-ab00a397b481" });

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "TaskEnd",
                value: new DateTime(2023, 1, 25, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "TaskEnd",
                value: new DateTime(2023, 1, 25, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TaskEnd", "TaskStart" },
                values: new object[] { new DateTime(2023, 1, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33244a2a-62a8-4f91-83ac-6435a1348629",
                column: "ConcurrencyStamp",
                value: "5342f6b7-f50c-4112-9fdc-57b61d7e2e6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40c6bc97-f08f-41e4-bf60-ccd30ff4ab41",
                column: "ConcurrencyStamp",
                value: "d8655991-5a18-49c2-a9ee-a8444e544418");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0463448f-fe47-41ab-9e99-b0245c4e7e84",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AFFF9u+XTSJxAMG2kc11oGH31a4tuLpQ2AJsZl7mGM4kW1Xd5QF0ZBTONJZ45f563A==", "7089a9a6-a004-4cce-b8c7-0cc5b3408940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4808c606-89cf-4a92-8ff6-33074a34a335",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AJ/cs6i+l03LmaLjQ0x+VDS45SXZyXKw4trDO1hu2PsGe+nUoaeOOt6EYQC8Nb2sAQ==", "88e67661-bbb1-43ab-b0c0-bf697adf4ca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3f4a9b-6a9d-4514-9197-64c599ca7cde",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AKQ4GLD624YDtf/E5a6ph3CCyXSakp2bQZg+aOYa6wOf8E4d+/FgClaXlUBmYr8NIw==", "dcd57d89-4bf6-4dbe-acd9-5b67f26768c5" });

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "TaskEnd",
                value: new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "TaskEnd",
                value: new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "EmployeeTasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TaskEnd", "TaskStart" },
                values: new object[] { new DateTime(2023, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 9, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
