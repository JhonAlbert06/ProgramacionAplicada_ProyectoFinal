using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_JhonAlbert.Migrations
{
    public partial class Decima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "FacturaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "FacturaDetalle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "FacturaId");
        }
    }
}
