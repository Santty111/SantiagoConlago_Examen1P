using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SantiagoConlago_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class SCtablita2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SCPrecio",
                table: "SantiagoConlago_model",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "SCGarantia",
                table: "SantiagoConlago_model",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "SCPrecioDate",
                table: "SantiagoConlago_model",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SCPrecioDate",
                table: "SantiagoConlago_model");

            migrationBuilder.AlterColumn<decimal>(
                name: "SCPrecio",
                table: "SantiagoConlago_model",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SCGarantia",
                table: "SantiagoConlago_model",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
