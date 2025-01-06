using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace artari.entities.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "artari",
                table: "Product",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "artari",
                table: "Product",
                columns: new[] { "Id", "Cultivar", "Description", "Height", "ImageUrl", "IsNew", "IsSoldout", "Name", "Price", "Priority", "Propagation", "Species", "SpeciesName", "Type", "TypeName" },
                values: new object[,]
                {
                    { -3, "Green Cascade", "green leaves", "22", "img artar Green Cascade", false, false, "Acer japonicum Green Cascade", 12.800000000000001, 1, "propagation details for Green Cascade", 3, "Japonicum", 0, "Acer" },
                    { -2, "Atropurpureum", "red leaves", "22", "img artar Atropurpureum", false, false, "Acer dissectum Atropurpureum", 58.0, 2, "propagation details for Atropurpureum", 1, "Dissectum", 0, "Acer" },
                    { -1, "Bloodgood", "red leaves", "22", "img artar Bloodgood", false, false, "Acer palmatum Bloodgood", 55.0, 1, "propagation details for Bloodgood", 0, "Palmatum", 0, "Acer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "artari",
                table: "Product",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "artari",
                table: "Product",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                schema: "artari",
                table: "Product",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "artari",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldNullable: true);
        }
    }
}
