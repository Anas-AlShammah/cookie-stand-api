using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salmon.Migrations
{
    /// <inheritdoc />
    public partial class first2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HourlySale_Cookiestands_CookieStandId",
                table: "HourlySale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlySale",
                table: "HourlySale");

            migrationBuilder.RenameTable(
                name: "HourlySale",
                newName: "HourlySales");

            migrationBuilder.RenameIndex(
                name: "IX_HourlySale_CookieStandId",
                table: "HourlySales",
                newName: "IX_HourlySales_CookieStandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlySales",
                table: "HourlySales",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HourlySales_Cookiestands_CookieStandId",
                table: "HourlySales",
                column: "CookieStandId",
                principalTable: "Cookiestands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HourlySales_Cookiestands_CookieStandId",
                table: "HourlySales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlySales",
                table: "HourlySales");

            migrationBuilder.RenameTable(
                name: "HourlySales",
                newName: "HourlySale");

            migrationBuilder.RenameIndex(
                name: "IX_HourlySales_CookieStandId",
                table: "HourlySale",
                newName: "IX_HourlySale_CookieStandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlySale",
                table: "HourlySale",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HourlySale_Cookiestands_CookieStandId",
                table: "HourlySale",
                column: "CookieStandId",
                principalTable: "Cookiestands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
