using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salmon.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cookiestands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minimum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    maximum_customers_per_hour = table.Column<int>(type: "int", nullable: false),
                    average_cookies_per_sale = table.Column<double>(type: "float", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookiestands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourlySale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CookieStandId = table.Column<int>(type: "int", nullable: false),
                    SalesValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlySale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourlySale_Cookiestands_CookieStandId",
                        column: x => x.CookieStandId,
                        principalTable: "Cookiestands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HourlySale_CookieStandId",
                table: "HourlySale",
                column: "CookieStandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourlySale");

            migrationBuilder.DropTable(
                name: "Cookiestands");
        }
    }
}
