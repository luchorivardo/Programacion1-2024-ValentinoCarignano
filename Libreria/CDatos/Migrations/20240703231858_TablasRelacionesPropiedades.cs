using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class TablasRelacionesPropiedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BiografiaAutor",
                table: "Autor");

            migrationBuilder.RenameColumn(
                name: "NacionalidadAutor",
                table: "Autor",
                newName: "Biografia");

            migrationBuilder.RenameColumn(
                name: "FechaNacimientoAutor",
                table: "Autor",
                newName: "FechaNacimiento");

            migrationBuilder.RenameColumn(
                name: "CantidadLibrosEscritosAutor",
                table: "Autor",
                newName: "CantidadLibrosEscritos");

            migrationBuilder.AddColumn<string>(
                name: "Nacionalidad",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nacionalidad",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "FechaNacimiento",
                table: "Autor",
                newName: "FechaNacimientoAutor");

            migrationBuilder.RenameColumn(
                name: "CantidadLibrosEscritos",
                table: "Autor",
                newName: "CantidadLibrosEscritosAutor");

            migrationBuilder.RenameColumn(
                name: "Biografia",
                table: "Autor",
                newName: "NacionalidadAutor");

            migrationBuilder.AddColumn<string>(
                name: "BiografiaAutor",
                table: "Autor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
