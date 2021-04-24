using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAPI.Migrations
{
    public partial class PoprawionyInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Country_ContinentId",
                table: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ContinentId",
                table: "Country",
                column: "ContinentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Country_ContinentId",
                table: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ContinentId",
                table: "Country",
                column: "ContinentId",
                unique: true);
        }
    }
}
