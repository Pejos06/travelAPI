using Microsoft.EntityFrameworkCore.Migrations;

namespace travelAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContinentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContinentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capitol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    CountryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContinentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Continent_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonumentDescription = table.Column<int>(type: "int", nullable: false),
                    MonumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monument_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Country_ContinentId",
                table: "Country",
                column: "ContinentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monument_CountryId",
                table: "Monument",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monument");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Continent");
        }
    }
}
