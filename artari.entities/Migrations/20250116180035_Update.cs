using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace artari.entities.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOrders",
                schema: "artari");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                schema: "artari",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                schema: "artari",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "artari",
                table: "Order",
                column: "CustomerId",
                principalSchema: "artari",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "artari",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                schema: "artari",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "artari",
                table: "Order");

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                schema: "artari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
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
        }
    }
}
