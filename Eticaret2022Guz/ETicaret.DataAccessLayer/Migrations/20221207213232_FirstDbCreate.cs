using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccessLayer.Migrations
{
    public partial class FirstDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CustomerEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CustomerUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CustomerStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    varchar = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    OrderCount = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    OrderStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubCategoryStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryStatus", "SortKey" },
                values: new object[] { 1, "Elektronik", true, (short)1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthDay", "datetime", "CustomerEmail", "CustomerLastName", "CustomerName", "CustomerStatus", "CustomerUserName", "varchar" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 8, 0, 32, 31, 937, DateTimeKind.Local).AddTicks(2302), "tt@gmail.com", "Tanin", "Tuncay", true, "tt", "+905327411235" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "SortKey", "SubCategoryName", "SubCategoryStatu" },
                values: new object[] { 1, (short)1, "Telefon", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
