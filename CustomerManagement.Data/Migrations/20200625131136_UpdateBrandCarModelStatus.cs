using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class UpdateBrandCarModelStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "CarModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Brands",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3a65fd30-6976-4aca-bef9-40683ffd5962");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b52f49a-dfed-4665-848f-a4127bf8a4a8", "AQAAAAEAACcQAAAAEM2vdkr9+cSCqtjLxAGZ/oockwK4pH5hq+/6ts2hA1ROH77ozcyO+pQF5Z60VSk6bg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Brands");

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

            migrationBuilder.UpdateData(
                table: "EmployeePositions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7fe41aa3-6010-49a3-b020-2c49f5ce3a8d");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c3e1c7f-e15c-4fb9-ba91-4de8015ed313", "AQAAAAEAACcQAAAAENKna5z8OUPEaOd/CVpsZ+o2JpLfjz1OUz1mihgjkn3BXhXjLfpD3x5taM+kSKD5Pg==" });
        }
    }
}
