using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcialherramientas.Migrations
{
    /// <inheritdoc />
    public partial class AddBookId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Book");
        }
    }
}
