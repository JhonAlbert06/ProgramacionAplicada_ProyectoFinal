using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_JhonAlbert.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Facturas_FacturaId",
                table: "FacturaDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedimientos",
                table: "Procedimientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.RenameTable(
                name: "Procedimientos",
                newName: "Procedimiento");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Paciente");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "Factura");

            migrationBuilder.AlterColumn<string>(
                name: "Procedimiento",
                table: "FacturaDetalle",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Procedimiento",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Procedimiento",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedimiento",
                table: "Procedimiento",
                column: "ProcedimientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                column: "PacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factura",
                table: "Factura",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId",
                principalTable: "Factura",
                principalColumn: "FacturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturaDetalle_Factura_FacturaId",
                table: "FacturaDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedimiento",
                table: "Procedimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factura",
                table: "Factura");

            migrationBuilder.RenameTable(
                name: "Procedimiento",
                newName: "Procedimientos");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Factura",
                newName: "Facturas");

            migrationBuilder.AlterColumn<string>(
                name: "Procedimiento",
                table: "FacturaDetalle",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Procedimientos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Procedimientos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedimientos",
                table: "Procedimientos",
                column: "ProcedimientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "PacienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturaDetalle_Facturas_FacturaId",
                table: "FacturaDetalle",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "FacturaId");
        }
    }
}
