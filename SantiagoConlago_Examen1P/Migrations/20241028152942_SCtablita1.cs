using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SantiagoConlago_Examen1P.Migrations
{
    /// <inheritdoc />
    public partial class SCtablita1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SantiagoConlago_model",
                columns: table => new
                {
                    SantiagoConlago_modelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCVideojuego = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCGarantia = table.Column<bool>(type: "bit", nullable: false),
                    SCPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SantiagoConlago_model", x => x.SantiagoConlago_modelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SantiagoConlago_model");
        }
    }
}
