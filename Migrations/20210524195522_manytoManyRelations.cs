using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class manytoManyRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_publisher_publisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publisher",
                table: "publisher");

            migrationBuilder.RenameTable(
                name: "publisher",
                newName: "publishers");

            migrationBuilder.AlterColumn<int>(
                name: "publisherId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishers",
                table: "publishers",
                column: "publisherId");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    authorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorFullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.authorId);
                });

            migrationBuilder.CreateTable(
                name: "books_Authors",
                columns: table => new
                {
                    bookAuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    authorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books_Authors", x => x.bookAuthorId);
                    table.ForeignKey(
                        name: "FK_books_Authors_Authors_authorId",
                        column: x => x.authorId,
                        principalTable: "Authors",
                        principalColumn: "authorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_Authors_Books_bookId",
                        column: x => x.bookId,
                        principalTable: "Books",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_Authors_authorId",
                table: "books_Authors",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_books_Authors_bookId",
                table: "books_Authors",
                column: "bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publishers_publisherId",
                table: "Books",
                column: "publisherId",
                principalTable: "publishers",
                principalColumn: "publisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_publishers_publisherId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "books_Authors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publishers",
                table: "publishers");

            migrationBuilder.RenameTable(
                name: "publishers",
                newName: "publisher");

            migrationBuilder.AlterColumn<int>(
                name: "publisherId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publisher",
                table: "publisher",
                column: "publisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publisher_publisherId",
                table: "Books",
                column: "publisherId",
                principalTable: "publisher",
                principalColumn: "publisherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
