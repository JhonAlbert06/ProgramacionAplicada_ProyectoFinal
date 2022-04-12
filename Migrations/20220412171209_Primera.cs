using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_JhonAlbert.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aseguradora",
                columns: table => new
                {
                    AseguradoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aseguradora", x => x.AseguradoraId);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Procedimiento",
                columns: table => new
                {
                    ProcedimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    TotalVendido = table.Column<float>(type: "real", nullable: false),
                    CantidadVendido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimiento", x => x.ProcedimientoId);
                });

            migrationBuilder.CreateTable(
                name: "FacturaDetalle",
                columns: table => new
                {
                    FacturaDetalleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacturaId = table.Column<int>(type: "int", nullable: false),
                    ProcedimientoId = table.Column<int>(type: "int", nullable: false),
                    Procedimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturaDetalle", x => x.FacturaDetalleId);
                    table.ForeignKey(
                        name: "FK_FacturaDetalle_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Senasa" },
                    { 2, "Humano" },
                    { 3, "Seguros Universal" },
                    { 4, "Reservas" },
                    { 5, "Mapfre BHD" },
                    { 6, "La Monumental" },
                    { 7, "Mapfre BHD" },
                    { 8, "La Monumental" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacturaDetalle_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aseguradora");

            migrationBuilder.DropTable(
                name: "FacturaDetalle");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Procedimiento");

            migrationBuilder.DropTable(
                name: "Factura");
        }
    }
}
