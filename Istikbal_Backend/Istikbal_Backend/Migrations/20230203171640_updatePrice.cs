using Microsoft.EntityFrameworkCore.Migrations;

namespace Istikbal_Backend.Migrations
{
    public partial class updatePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryIns_CategoryInId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryInId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryInId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderItem",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "Order",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryInId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Order",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryInId",
                table: "Products",
                column: "CategoryInId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryIns_CategoryInId",
                table: "Products",
                column: "CategoryInId",
                principalTable: "CategoryIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
