using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordgeo",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Lon = table.Column<double>(type: "REAL", nullable: false),
                    Lat = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordgeo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CctSiret = table.Column<string>(type: "TEXT", nullable: true),
                    CctDenomination = table.Column<string>(type: "TEXT", nullable: true),
                    CctAdresse = table.Column<string>(type: "TEXT", nullable: true),
                    CoordgeoId = table.Column<string>(type: "TEXT", nullable: true),
                    CctCodeCommune = table.Column<string>(type: "TEXT", nullable: true),
                    CodePostal = table.Column<string>(type: "TEXT", nullable: true),
                    CctTel = table.Column<string>(type: "TEXT", nullable: true),
                    CctUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Region = table.Column<string>(type: "TEXT", nullable: true),
                    CodeRegion = table.Column<long>(type: "INTEGER", nullable: false),
                    Departement = table.Column<string>(type: "TEXT", nullable: true),
                    CodeDepartement = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Field_Coordgeo_CoordgeoId",
                        column: x => x.CoordgeoId,
                        principalTable: "Coordgeo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Field_CoordgeoId",
                table: "Field",
                column: "CoordgeoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Coordgeo");
        }
    }
}
