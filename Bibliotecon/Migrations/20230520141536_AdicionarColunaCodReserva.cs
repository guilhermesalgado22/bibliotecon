using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotecon.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarColunaCodReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodReserva",
                table: "tb_exemplar_emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservaCodReserva",
                table: "tb_exemplar_emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_exemplar_emprestimo_ReservaCodReserva",
                table: "tb_exemplar_emprestimo",
                column: "ReservaCodReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva",
                table: "tb_exemplar_emprestimo",
                column: "ReservaCodReserva",
                principalTable: "tb_reserva",
                principalColumn: "cod_reserva",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_tb_exemplar_emprestimo_ReservaCodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropColumn(
                name: "CodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropColumn(
                name: "ReservaCodReserva",
                table: "tb_exemplar_emprestimo");
        }
    }
}
