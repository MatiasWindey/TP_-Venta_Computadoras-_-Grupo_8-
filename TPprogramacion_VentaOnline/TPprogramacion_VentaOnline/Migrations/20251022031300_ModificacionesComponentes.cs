using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPprogramacion_VentaOnline.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionesComponentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Precio",
                table: "Componentes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Componentes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Componentes");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Componentes");
        }
    }
}
