using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuscaBook.Migrations
{
    /// <inheritdoc />
    public partial class addTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Reserva",
                table: "Livros",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TempoPreviaReserva",
                table: "Livros",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TempoReserva",
                table: "Livros",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reserva",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "TempoPreviaReserva",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "TempoReserva",
                table: "Livros");
        }
    }
}
