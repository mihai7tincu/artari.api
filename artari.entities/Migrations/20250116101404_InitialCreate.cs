using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                name: "Customer",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<long>(type: "bigint", nullable: true),
                    PickupDelivery = table.Column<bool>(type: "bit", nullable: true),
                    PayOnDelivery = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNew = table.Column<bool>(type: "bit", nullable: true),
                    IsSoldout = table.Column<bool>(type: "bit", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    Propagation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeciesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cultivar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "artari",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "artari",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "artari",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "artari",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "artari",
                table: "Product",
                columns: new[] { "Id", "Cultivar", "Description", "Height", "ImageUrl", "IsNew", "IsSoldout", "Name", "Price", "Priority", "Propagation", "Species", "SpeciesName", "Type", "TypeName" },
                values: new object[,]
                {
                    { 1, "Bloodgood", "red leaves", "22", "img artar Bloodgood", false, false, "Acer palmatum Bloodgood", 55.0, 1, "propagation details for Bloodgood", 0, "Palmatum", 0, "Acer" },
                    { 2, "Atropurpureum", "red leaves", "22", "img artar Atropurpureum", false, false, "Acer dissectum Atropurpureum", 58.0, 2, "propagation details for Atropurpureum", 1, "Dissectum", 0, "Acer" },
                    { 3, "Green Cascade", "green leaves", "22", "img artar Green Cascade", false, false, "Acer japonicum Green Cascade", 12.800000000000001, 1, "propagation details for Green Cascade", 3, "Japonicum", 0, "Acer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Phone",
                schema: "artari",
                table: "Customer",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_CustomerId",
                schema: "artari",
                table: "CustomerOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_OrderId",
                schema: "artari",
                table: "CustomerOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                schema: "artari",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                schema: "artari",
                table: "OrderProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOrders",
                schema: "artari");

            migrationBuilder.DropTable(
                name: "OrderProducts",
                schema: "artari");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "artari");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "artari");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "artari");
        }
    }
}
