using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class bookAuthorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookAuthor",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bookAuthor",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
