using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace artari.entities.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "artari");

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IsNew = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsSoldout = table.Column<bool>(type: "INTEGER", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    TypeName = table.Column<string>(type: "TEXT", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: true),
                    Propagation = table.Column<string>(type: "TEXT", nullable: true),
                    SpeciesName = table.Column<string>(type: "TEXT", nullable: true),
                    Cultivar = table.Column<string>(type: "TEXT", nullable: true),
                    Species = table.Column<int>(type: "INTEGER", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "artari");
        }
    }
}
