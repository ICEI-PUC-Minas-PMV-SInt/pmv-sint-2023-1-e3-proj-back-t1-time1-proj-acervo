using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuscaBook.Migrations
{
    /// <inheritdoc />
    public partial class MediumTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroPaginas",
                table: "Livros");

            migrationBuilder.AddColumn<bool>(
                name: "Alugado",
                table: "Livros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TempoAluguel",
                table: "Livros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ReservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Usuário = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDeAluguel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeExpiracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ReservaId);
                    table.ForeignKey(
                        name: "FK_Reserva_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_LivroId",
                table: "Reserva",
                column: "LivroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropColumn(
                name: "Alugado",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "TempoAluguel",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "NumeroPaginas",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
