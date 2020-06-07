using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BookStore.Migrations
{
    public partial class Add_Table_Menu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    order = table.Column<int>(type: "int(11)", nullable: false, defaultValue: 0),
                    parentId = table.Column<int>(type: "int(11)", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.id);
                });

            migrationBuilder.InsertData("menu",
                new[] { "id", "title", "order", "parentId" },
                new object[,]
                {
                    { 1, "Home", 0, 0},
                    { 2, "Shop", 1, 0},
                    { 3, "Page", 2, 0},
                    { 4, "Blog", 3, 0},
                    { 5, "Contact", 4, 0},
                    { 6, "Home One", 0, 1},
                    { 7, "Home Two", 1, 1},
                    { 8, "Home Three", 2, 1},
                    { 9, "Fullwidth", 0, 2},
                    { 10, "Left Sidebar", 1, 2},
                    { 11, "Right Sidebar", 2, 2},
                    { 12, "Fullwidth", 3, 2},
                    { 13, "Left Sidebar", 4, 2},
                    { 14, "Right Sidebar", 5, 2},
                    { 15, "Cart", 0, 3},
                    { 16, "Checkout", 1, 3},
                    { 17, "Compare", 2, 3},
                    { 18, "Wishlist", 3, 3},
                    { 19, "Full Widh (Default)", 0, 4},
                    { 20, "Left Sidebar", 1, 4},
                    { 21, "Right Sidebar", 2, 4},
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menu");
        }
    }
}
