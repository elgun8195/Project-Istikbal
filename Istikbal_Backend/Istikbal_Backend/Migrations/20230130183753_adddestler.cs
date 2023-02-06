using Microsoft.EntityFrameworkCore.Migrations;

namespace Istikbal_Backend.Migrations
{
    public partial class adddestler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryIns_CategoryInId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryIns_Categories_CategoryId",
                table: "CategoryIns");

            migrationBuilder.DropIndex(
                name: "IX_CategoryIns_CategoryId",
                table: "CategoryIns");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryInId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CategoryIns");

            migrationBuilder.DropColumn(
                name: "CategoryInId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryDests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryInId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryDests_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDests_CategoryIns_CategoryInId",
                        column: x => x.CategoryInId,
                        principalTable: "CategoryIns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDests_CategoryId",
                table: "CategoryDests",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDests_CategoryInId",
                table: "CategoryDests",
                column: "CategoryInId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDests");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CategoryIns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryInId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryIns_CategoryId",
                table: "CategoryIns",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryInId",
                table: "Categories",
                column: "CategoryInId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryIns_CategoryInId",
                table: "Categories",
                column: "CategoryInId",
                principalTable: "CategoryIns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryIns_Categories_CategoryId",
                table: "CategoryIns",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
