using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistance.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 14m },
                    { 72, "Description for product 72", "Product 72", 14m },
                    { 71, "Description for product 71", "Product 71", 55m },
                    { 70, "Description for product 70", "Product 70", 60m },
                    { 69, "Description for product 69", "Product 69", 66m },
                    { 68, "Description for product 68", "Product 68", 77m },
                    { 67, "Description for product 67", "Product 67", 84m },
                    { 66, "Description for product 66", "Product 66", 74m },
                    { 65, "Description for product 65", "Product 65", 73m },
                    { 64, "Description for product 64", "Product 64", 53m },
                    { 63, "Description for product 63", "Product 63", 80m },
                    { 62, "Description for product 62", "Product 62", 92m },
                    { 61, "Description for product 61", "Product 61", 41m },
                    { 60, "Description for product 60", "Product 60", 15m },
                    { 59, "Description for product 59", "Product 59", 10m },
                    { 58, "Description for product 58", "Product 58", 45m },
                    { 57, "Description for product 57", "Product 57", 63m },
                    { 56, "Description for product 56", "Product 56", 79m },
                    { 55, "Description for product 55", "Product 55", 67m },
                    { 54, "Description for product 54", "Product 54", 31m },
                    { 53, "Description for product 53", "Product 53", 30m },
                    { 52, "Description for product 52", "Product 52", 22m },
                    { 73, "Description for product 73", "Product 73", 67m },
                    { 51, "Description for product 51", "Product 51", 22m },
                    { 74, "Description for product 74", "Product 74", 70m },
                    { 76, "Description for product 76", "Product 76", 20m },
                    { 97, "Description for product 97", "Product 97", 64m },
                    { 96, "Description for product 96", "Product 96", 59m },
                    { 95, "Description for product 95", "Product 95", 84m },
                    { 94, "Description for product 94", "Product 94", 23m },
                    { 93, "Description for product 93", "Product 93", 87m },
                    { 92, "Description for product 92", "Product 92", 11m },
                    { 91, "Description for product 91", "Product 91", 72m },
                    { 90, "Description for product 90", "Product 90", 50m },
                    { 89, "Description for product 89", "Product 89", 25m },
                    { 88, "Description for product 88", "Product 88", 30m },
                    { 87, "Description for product 87", "Product 87", 11m },
                    { 86, "Description for product 86", "Product 86", 56m },
                    { 85, "Description for product 85", "Product 85", 30m },
                    { 84, "Description for product 84", "Product 84", 22m },
                    { 83, "Description for product 83", "Product 83", 82m },
                    { 82, "Description for product 82", "Product 82", 89m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 81, "Description for product 81", "Product 81", 19m },
                    { 80, "Description for product 80", "Product 80", 51m },
                    { 79, "Description for product 79", "Product 79", 12m },
                    { 78, "Description for product 78", "Product 78", 66m },
                    { 77, "Description for product 77", "Product 77", 34m },
                    { 75, "Description for product 75", "Product 75", 74m },
                    { 98, "Description for product 98", "Product 98", 57m },
                    { 50, "Description for product 50", "Product 50", 74m },
                    { 48, "Description for product 48", "Product 48", 93m },
                    { 22, "Description for product 22", "Product 22", 35m },
                    { 21, "Description for product 21", "Product 21", 55m },
                    { 20, "Description for product 20", "Product 20", 26m },
                    { 19, "Description for product 19", "Product 19", 87m },
                    { 18, "Description for product 18", "Product 18", 86m },
                    { 17, "Description for product 17", "Product 17", 92m },
                    { 16, "Description for product 16", "Product 16", 92m },
                    { 15, "Description for product 15", "Product 15", 87m },
                    { 14, "Description for product 14", "Product 14", 87m },
                    { 13, "Description for product 13", "Product 13", 60m },
                    { 12, "Description for product 12", "Product 12", 35m },
                    { 11, "Description for product 11", "Product 11", 97m },
                    { 10, "Description for product 10", "Product 10", 43m },
                    { 9, "Description for product 9", "Product 9", 86m },
                    { 8, "Description for product 8", "Product 8", 67m },
                    { 7, "Description for product 7", "Product 7", 51m },
                    { 6, "Description for product 6", "Product 6", 24m },
                    { 5, "Description for product 5", "Product 5", 33m },
                    { 4, "Description for product 4", "Product 4", 56m },
                    { 3, "Description for product 3", "Product 3", 15m },
                    { 2, "Description for product 2", "Product 2", 40m },
                    { 23, "Description for product 23", "Product 23", 76m },
                    { 49, "Description for product 49", "Product 49", 75m },
                    { 24, "Description for product 24", "Product 24", 70m },
                    { 26, "Description for product 26", "Product 26", 27m },
                    { 47, "Description for product 47", "Product 47", 18m },
                    { 46, "Description for product 46", "Product 46", 14m },
                    { 45, "Description for product 45", "Product 45", 67m },
                    { 44, "Description for product 44", "Product 44", 20m },
                    { 43, "Description for product 43", "Product 43", 10m },
                    { 42, "Description for product 42", "Product 42", 45m },
                    { 41, "Description for product 41", "Product 41", 51m },
                    { 40, "Description for product 40", "Product 40", 26m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 39, "Description for product 39", "Product 39", 28m },
                    { 38, "Description for product 38", "Product 38", 88m },
                    { 37, "Description for product 37", "Product 37", 47m },
                    { 36, "Description for product 36", "Product 36", 36m },
                    { 35, "Description for product 35", "Product 35", 30m },
                    { 34, "Description for product 34", "Product 34", 82m },
                    { 33, "Description for product 33", "Product 33", 51m },
                    { 32, "Description for product 32", "Product 32", 32m },
                    { 31, "Description for product 31", "Product 31", 69m },
                    { 30, "Description for product 30", "Product 30", 43m },
                    { 29, "Description for product 29", "Product 29", 87m },
                    { 28, "Description for product 28", "Product 28", 58m },
                    { 27, "Description for product 27", "Product 27", 82m },
                    { 25, "Description for product 25", "Product 25", 55m },
                    { 99, "Description for product 99", "Product 99", 46m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 72, 72, 5 },
                    { 71, 71, 18 },
                    { 70, 70, 19 },
                    { 69, 69, 7 },
                    { 68, 68, 3 },
                    { 67, 67, 3 },
                    { 66, 66, 14 },
                    { 65, 65, 5 },
                    { 64, 64, 15 },
                    { 63, 63, 6 },
                    { 62, 62, 12 },
                    { 61, 61, 7 },
                    { 60, 60, 10 },
                    { 59, 59, 14 },
                    { 58, 58, 6 },
                    { 57, 57, 0 },
                    { 56, 56, 3 },
                    { 55, 55, 7 },
                    { 54, 54, 13 },
                    { 53, 53, 9 },
                    { 52, 52, 19 },
                    { 73, 73, 4 },
                    { 51, 51, 17 },
                    { 74, 74, 16 },
                    { 76, 76, 1 },
                    { 97, 97, 14 },
                    { 96, 96, 5 },
                    { 95, 95, 3 },
                    { 94, 94, 14 },
                    { 93, 93, 8 },
                    { 92, 92, 6 },
                    { 91, 91, 5 },
                    { 90, 90, 1 },
                    { 89, 89, 7 },
                    { 88, 88, 16 },
                    { 87, 87, 5 },
                    { 86, 86, 5 },
                    { 85, 85, 5 },
                    { 84, 84, 7 },
                    { 83, 83, 17 },
                    { 82, 82, 9 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 81, 81, 1 },
                    { 80, 80, 14 },
                    { 79, 79, 3 },
                    { 78, 78, 9 },
                    { 77, 77, 12 },
                    { 75, 75, 19 },
                    { 98, 98, 10 },
                    { 50, 50, 14 },
                    { 48, 48, 6 },
                    { 22, 22, 18 },
                    { 21, 21, 3 },
                    { 20, 20, 18 },
                    { 19, 19, 7 },
                    { 18, 18, 8 },
                    { 17, 17, 7 },
                    { 16, 16, 10 },
                    { 15, 15, 5 },
                    { 14, 14, 13 },
                    { 13, 13, 17 },
                    { 12, 12, 13 },
                    { 11, 11, 10 },
                    { 10, 10, 10 },
                    { 9, 9, 19 },
                    { 8, 8, 8 },
                    { 7, 7, 19 },
                    { 6, 6, 4 },
                    { 5, 5, 3 },
                    { 4, 4, 3 },
                    { 3, 3, 0 },
                    { 2, 2, 6 },
                    { 23, 23, 6 },
                    { 49, 49, 9 },
                    { 24, 24, 14 },
                    { 26, 26, 12 },
                    { 47, 47, 11 },
                    { 46, 46, 14 },
                    { 45, 45, 10 },
                    { 44, 44, 17 },
                    { 43, 43, 6 },
                    { 42, 42, 1 },
                    { 41, 41, 18 },
                    { 40, 40, 10 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 39, 39, 4 },
                    { 38, 38, 2 },
                    { 37, 37, 12 },
                    { 36, 36, 6 },
                    { 35, 35, 5 },
                    { 34, 34, 14 },
                    { 33, 33, 9 },
                    { 32, 32, 15 },
                    { 31, 31, 5 },
                    { 30, 30, 3 },
                    { 29, 29, 2 },
                    { 28, 28, 6 },
                    { 27, 27, 16 },
                    { 25, 25, 9 },
                    { 99, 99, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
