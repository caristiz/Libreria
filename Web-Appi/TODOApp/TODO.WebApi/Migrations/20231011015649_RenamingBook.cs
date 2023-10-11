using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TODO.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class RenamingBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BooksId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BooksId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "Reviews");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BooksId",
                table: "Reviews",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BooksId",
                table: "Reviews",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
