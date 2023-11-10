using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RectMatch_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_X1",
                table: "Rectangles",
                column: "X1");

            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_X2",
                table: "Rectangles",
                column: "X2");

            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_Y1",
                table: "Rectangles",
                column: "Y1");

            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_Y2",
                table: "Rectangles",
                column: "Y2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rectangles_X1",
                table: "Rectangles");

            migrationBuilder.DropIndex(
                name: "IX_Rectangles_X2",
                table: "Rectangles");

            migrationBuilder.DropIndex(
                name: "IX_Rectangles_Y1",
                table: "Rectangles");

            migrationBuilder.DropIndex(
                name: "IX_Rectangles_Y2",
                table: "Rectangles");
        }
    }
}
