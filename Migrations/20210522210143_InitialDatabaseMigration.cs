using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class InitialDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isRead = table.Column<bool>(type: "bit", nullable: false),
                    dateRead = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bookRate = table.Column<int>(type: "int", nullable: true),
                    bookCoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookDateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bookAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
