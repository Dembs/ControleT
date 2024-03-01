using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Field_FieldsId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Roots_RootId",
                table: "Records");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropIndex(
                name: "IX_Records_FieldsId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_RootId",
                table: "Records");

            migrationBuilder.RenameColumn(
                name: "RootId",
                table: "Records",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "FieldsId",
                table: "Records",
                newName: "Departement");

            migrationBuilder.AddColumn<string>(
                name: "CctAdresse",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CctCodeCommune",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CctDenomination",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CctSiret",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CctTel",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CctUrl",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeDepartement",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodePostal",
                table: "Records",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodeRegion",
                table: "Records",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CctAdresse",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CctCodeCommune",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CctDenomination",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CctSiret",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CctTel",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CctUrl",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CodeDepartement",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CodePostal",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CodeRegion",
                table: "Records");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Records",
                newName: "RootId");

            migrationBuilder.RenameColumn(
                name: "Departement",
                table: "Records",
                newName: "FieldsId");

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CctAdresse = table.Column<string>(type: "TEXT", nullable: true),
                    CctCodeCommune = table.Column<string>(type: "TEXT", nullable: true),
                    CctDenomination = table.Column<string>(type: "TEXT", nullable: true),
                    CctSiret = table.Column<string>(type: "TEXT", nullable: true),
                    CctTel = table.Column<string>(type: "TEXT", nullable: true),
                    CctUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CodeDepartement = table.Column<string>(type: "TEXT", nullable: true),
                    CodePostal = table.Column<string>(type: "TEXT", nullable: true),
                    CodeRegion = table.Column<string>(type: "TEXT", nullable: true),
                    Departement = table.Column<string>(type: "TEXT", nullable: true),
                    Region = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_FieldsId",
                table: "Records",
                column: "FieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_RootId",
                table: "Records",
                column: "RootId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Field_FieldsId",
                table: "Records",
                column: "FieldsId",
                principalTable: "Field",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Roots_RootId",
                table: "Records",
                column: "RootId",
                principalTable: "Roots",
                principalColumn: "Id");
        }
    }
}
