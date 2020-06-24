using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class updateDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2020, 1868000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1128000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1218000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2020, 1288000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1128000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1218000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1288000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1516000000L, 2019 });

            migrationBuilder.InsertData(
                table: "EmployeePositionEmployees",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "EmployeePositions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName", "ParentId" },
                values: new object[] { 1, "7fe41aa3-6010-49a3-b020-2c49f5ce3a8d", "Adminstrator", "adminstrator", null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "ExitDate", "FirstName", "Gender", "JoinDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "YearOfExperience" },
                values: new object[] { 1, 0, "4c3e1c7f-e15c-4fb9-ba91-4de8015ed313", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@subarukimson.vn", true, null, "Tiến", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phan Ngọc", false, null, "admin@subarukimson.vn", "admin", "AQAAAAEAACcQAAAAENKna5z8OUPEaOd/CVpsZ+o2JpLfjz1OUz1mihgjkn3BXhXjLfpD3x5taM+kSKD5Pg==", null, false, "", false, "admin", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeePositionEmployees",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2020, 1868000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1128000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1218000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2020, 1288000000L, 2020 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1128000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1218000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1288000000L, 2019 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MY", "OriginalPrice", "YOM" },
                values: new object[] { 2019, 1516000000L, 2019 });
        }
    }
}
