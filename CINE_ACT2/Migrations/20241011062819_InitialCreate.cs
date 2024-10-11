using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CINE_ACT2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pelis",
                columns: table => new
                {
                    PeliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Directores = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Fecha = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Peli__5AC6FCCC37D98DA1", x => x.PeliId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pelicula");
        }
    }
}
