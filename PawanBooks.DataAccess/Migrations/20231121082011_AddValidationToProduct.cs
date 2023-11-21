using Microsoft.EntityFrameworkCore.Migrations;

namespace PawanBooks.DataAccess.Migrations
{
    public partial class AddValidationToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverTypes_CoverId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CoverId",
                table: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverTypes_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CoverTypes_CategoryId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CoverId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverId",
                table: "Products",
                column: "CoverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CoverTypes_CoverId",
                table: "Products",
                column: "CoverId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
