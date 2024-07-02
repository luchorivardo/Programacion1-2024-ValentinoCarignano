using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class DBUpdateseagregaronentidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Example");

            migrationBuilder.CreateTable(
                name: "Copia",
                columns: table => new
                {
                    IdCopia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioPrestamo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_COPIA", x => x.IdCopia);
                });

            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EDITORIAL", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_FORMAPAGO", x => x.IdFormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENERO", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PERSONA", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaLimite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_PRESTAMO", x => x.IdPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_VENTA", x => x.IdVenta);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false),
                    EditorialLibroIdEditorial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_LIBRO", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Editorial_EditorialLibroIdEditorial",
                        column: x => x.EditorialLibroIdEditorial,
                        principalTable: "Editorial",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    IdAutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaNacimientoAutor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BiografiaAutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NacionalidadAutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadLibrosEscritosAutor = table.Column<int>(type: "int", nullable: false),
                    PersonaAutorIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTOR", x => x.IdAutor);
                    table.ForeignKey(
                        name: "FK_Autor_Persona_PersonaAutorIdPersona",
                        column: x => x.PersonaAutorIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsSocio = table.Column<bool>(type: "bit", nullable: false),
                    PagaIVA = table.Column<bool>(type: "bit", nullable: false),
                    PersonaClienteIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona_PersonaClienteIdPersona",
                        column: x => x.PersonaClienteIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antiguedad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sueldo = table.Column<double>(type: "float", nullable: false),
                    PersonaEmpleadoIdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EMPLEADO", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona_PersonaEmpleadoIdPersona",
                        column: x => x.PersonaEmpleadoIdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneroLibro",
                columns: table => new
                {
                    IdGeneroLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibroGeneroLibroIdLibro = table.Column<int>(type: "int", nullable: false),
                    GeneroGeneroLibroIdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_GENEROLIBRO", x => x.IdGeneroLibro);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Genero_GeneroGeneroLibroIdGenero",
                        column: x => x.GeneroGeneroLibroIdGenero,
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroLibro_Libro_LibroGeneroLibroIdLibro",
                        column: x => x.LibroGeneroLibroIdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLibro",
                columns: table => new
                {
                    IdAutorLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorAutorLibroIdAutor = table.Column<int>(type: "int", nullable: false),
                    LibroAutorLibroIdLibro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_AUTORLIBRO", x => x.IdAutorLibro);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Autor_AutorAutorLibroIdAutor",
                        column: x => x.AutorAutorLibroIdAutor,
                        principalTable: "Autor",
                        principalColumn: "IdAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLibro_Libro_LibroAutorLibroIdLibro",
                        column: x => x.LibroAutorLibroIdLibro,
                        principalTable: "Libro",
                        principalColumn: "IdLibro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_PersonaAutorIdPersona",
                table: "Autor",
                column: "PersonaAutorIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_AutorAutorLibroIdAutor",
                table: "AutorLibro",
                column: "AutorAutorLibroIdAutor");

            migrationBuilder.CreateIndex(
                name: "IX_AutorLibro_LibroAutorLibroIdLibro",
                table: "AutorLibro",
                column: "LibroAutorLibroIdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PersonaClienteIdPersona",
                table: "Cliente",
                column: "PersonaClienteIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_PersonaEmpleadoIdPersona",
                table: "Empleado",
                column: "PersonaEmpleadoIdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_GeneroGeneroLibroIdGenero",
                table: "GeneroLibro",
                column: "GeneroGeneroLibroIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroLibro_LibroGeneroLibroIdLibro",
                table: "GeneroLibro",
                column: "LibroGeneroLibroIdLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_EditorialLibroIdEditorial",
                table: "Libro",
                column: "EditorialLibroIdEditorial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLibro");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Copia");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "GeneroLibro");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Editorial");

            migrationBuilder.CreateTable(
                name: "Example",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Texto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_EXAMPLE", x => x.Id);
                });
        }
    }
}
