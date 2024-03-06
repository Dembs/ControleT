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
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CctSiret = table.Column<string>(type: "TEXT", nullable: true),
                    CctDenomination = table.Column<string>(type: "TEXT", nullable: true),
                    CctAdresse = table.Column<string>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_Fields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    FieldsId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Fields_FieldsId",
                        column: x => x.FieldsId,
                        principalTable: "Fields",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_FieldsId",
                table: "Records",
                column: "FieldsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Fields");
        }
    }
}
