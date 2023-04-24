using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcialherramientas.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Genero",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EstaReservado",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Autor_AutorId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropIndex(
                name: "IX_Book_AutorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "EstaReservado",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Book",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
