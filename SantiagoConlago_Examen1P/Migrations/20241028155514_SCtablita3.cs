using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SantiagoConlago_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class SCtablita3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SCPrecioDate",
                table: "SantiagoConlago_model");

            migrationBuilder.AlterColumn<bool>(
                name: "SCGarantia",
                table: "SantiagoConlago_model",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SCDate",
                table: "SantiagoConlago_model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SCDate",
                table: "SantiagoConlago_model");

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
    }
}
