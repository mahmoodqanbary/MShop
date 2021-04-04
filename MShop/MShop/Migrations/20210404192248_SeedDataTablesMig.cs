using Microsoft.EntityFrameworkCore.Migrations;

namespace MShop.Migrations
{
    public partial class SeedDataTablesMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 1, 3302.0m, 8 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 2, 854.0m, 5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 3, 2500m, 3 });

            migrationBuilder.InsertData(
                table: "Prodacts",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 1, "پارچه کرپ حریر مناسب فصل تابستان و برای دوخت شومیز و مانتو مناسب است", 1, "پارچه کرپ حریر" });

            migrationBuilder.InsertData(
                table: "Prodacts",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 2, "پارچه نخی یک پارچه خنک و مناسب فصل تابستان است و برای دوخت بلوز شلوار و ماکسی بسیار مناسب است", 2, "پارچه نخی" });

            migrationBuilder.InsertData(
                table: "Prodacts",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 3, "پارچه کرپ مازراتی اتو رفت دارد اما بسیار شیک و برای دوخت مانتوهای مجلسی و گران قیمت مناسب است و همینطور زیر دست لطیف و نرمی دارد", 3, "پارچه کرپ مازراتی" });

            migrationBuilder.InsertData(
                table: "CategoryToProdacts",
                columns: new[] { "CategoryId", "ProdactId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryToProdacts",
                keyColumns: new[] { "CategoryId", "ProdactId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Prodacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prodacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prodacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");
        }
    }
}
