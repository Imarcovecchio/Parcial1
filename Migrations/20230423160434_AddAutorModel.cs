using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcialherramientas.Migrations
{
    /// <inheritdoc />
    public partial class AddAutorModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Autor_AutorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AutorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Autor_Id",
                table: "Book",
                column: "Id",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Autor_Id",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AutorId",
                table: "Book",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Autor_AutorId",
                table: "Book",
                column: "AutorId",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
