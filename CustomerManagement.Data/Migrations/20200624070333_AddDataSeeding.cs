using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerManagement.Data.Migrations
{
    public partial class AddDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "/brands-logo/subaru2019.png", "Subaru" },
                    { 2, "/brands-logo/mazda2019.png", "Mazda" }
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "Engine", "GearBox", "MY", "Name", "OriginalPrice", "YOM" },
                values: new object[,]
                {
                    { 1, "Boxer H4 2.5", "Lineartronic CVT", 2020, "Outback 2.5 ES 2020", 1868000000L, 2020 },
                    { 2, "Boxer H4 2.0", "Lineartronic CVT", 2019, "Forester iL 2020", 1128000000L, 2020 },
                    { 3, "Boxer H4 2.0", "Lineartronic CVT", 2019, "Forester iS 2020", 1218000000L, 2020 },
                    { 4, "Boxer H4 2.0", "Lineartronic CVT", 2020, "Forester iS ES 2020", 1288000000L, 2020 },
                    { 5, "Boxer H4 2.0", "Lineartronic CVT", 2019, "Forester iL 2019", 1128000000L, 2019 },
                    { 6, "Boxer H4 2.0", "Lineartronic CVT", 2019, "Forester iS 2019", 1218000000L, 2019 },
                    { 7, "Boxer H4 2.0", "Lineartronic CVT", 2019, "Forester iS ES 2019", 1288000000L, 2019 },
                    { 8, "Boxer H4 2.0", "Lineartronic CVT", 2019, "XV ES 2019", 1516000000L, 2019 }
                });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Outback" },
                    { 2, 1, "Forester" },
                    { 3, 1, "XV" },
                    { 4, 2, "Mazda 2" },
                    { 5, 2, "Mazda 3" },
                    { 6, 2, "Mazda 6" },
                    { 7, 2, "CX-5" },
                    { 8, 2, "BT50" }
                });

            migrationBuilder.InsertData(
                table: "CarColors",
                columns: new[] { "Id", "CarCategoryId", "EnglishName", "HEX", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Tungsten", "FFFFFF", "Vàng cát" },
                    { 11, 7, "Crystal Black", "FFFFFF", "Đen Huyền Bí" },
                    { 10, 6, "Horizontal Blue Pearl", "FFFFFF", "Xanh dương" },
                    { 9, 5, "Crystal White Pearl", "000000", "Trắng Ngọc Trai" },
                    { 8, 4, "Crystal Black", "FFFFFF", "Đen Huyền Bí" },
                    { 7, 3, "Orange", "FFFFFF", "Vàng cam" },
                    { 12, 8, "Crystal White Pearl", "000000", "Trắng Ngọc Trai" },
                    { 13, 8, "Horizontal Blue Pearl", "FFFFFF", "Xanh dương" },
                    { 6, 2, "Horizontal Blue Pearl", "FFFFFF", "Xanh dương" },
                    { 5, 2, "Crystal White Pearl", "000000", "Trắng Ngọc Trai" },
                    { 4, 2, "Crystal Black", "FFFFFF", "Đen Huyền Bí" },
                    { 3, 1, "Gray Blue", "FFFFFF", "Xanh xám" },
                    { 2, 1, "Crystal Black", "000000", "Đen Huyền Bí" }
                });

            migrationBuilder.InsertData(
                table: "CarModelCategories",
                columns: new[] { "CarCategoryId", "CarModelId" },
                values: new object[,]
                {
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarColors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "CarModelCategories",
                keyColumns: new[] { "CarCategoryId", "CarModelId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
