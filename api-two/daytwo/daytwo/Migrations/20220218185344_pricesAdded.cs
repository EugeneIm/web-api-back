using Microsoft.EntityFrameworkCore.Migrations;

namespace daytwo.Migrations
{
    public partial class pricesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProduceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProduceID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProduceID", "Description", "Price" },
                values: new object[] { 1, "Oranges", 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProduceID", "Description", "Price" },
                values: new object[] { 2, "Apples", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
