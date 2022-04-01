using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_JhonAlbert.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aseguradora",
                columns: table => new
                {
                    AseguradoraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aseguradora", x => x.AseguradoraId);
                });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 1, "Senasa" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 2, "Humano" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 3, "Seguros Universal" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 4, "Reservas" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 5, "Mapfre BHD" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 6, "La Monumental" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 7, "Mapfre BHD" });

            migrationBuilder.InsertData(
                table: "Aseguradora",
                columns: new[] { "AseguradoraId", "Nombre" },
                values: new object[] { 8, "La Monumental" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aseguradora");
        }
    }
}
