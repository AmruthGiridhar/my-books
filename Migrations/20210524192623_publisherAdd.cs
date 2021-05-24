using Microsoft.EntityFrameworkCore.Migrations;

namespace my_books.Migrations
{
    public partial class publisherAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "publisherId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "publisher",
                columns: table => new
                {
                    publisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    publisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisher", x => x.publisherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_publisherId",
                table: "Books",
                column: "publisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_publisher_publisherId",
                table: "Books",
                column: "publisherId",
                principalTable: "publisher",
                principalColumn: "publisherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_publisher_publisherId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "publisher");

            migrationBuilder.DropIndex(
                name: "IX_Books_publisherId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "publisherId",
                table: "Books");
        }
    }
}
