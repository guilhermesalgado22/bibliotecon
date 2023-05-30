using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotecon.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_tb_exemplar_emprestimo_ReservaCodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropColumn(
                name: "desc_exemplar",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.RenameColumn(
                name: "ReservaCodReserva",
                table: "tb_exemplar_emprestimo",
                newName: "CodLivro");

            migrationBuilder.AlterColumn<int>(
                name: "CodReserva",
                table: "tb_exemplar_emprestimo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_exemplar_emprestimo_CodReserva",
                table: "tb_exemplar_emprestimo",
                column: "CodReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva",
                table: "tb_exemplar_emprestimo",
                column: "CodReserva",
                principalTable: "tb_reserva",
                principalColumn: "cod_reserva");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_tb_exemplar_emprestimo_CodReserva",
                table: "tb_exemplar_emprestimo");

            migrationBuilder.RenameColumn(
                name: "CodLivro",
                table: "tb_exemplar_emprestimo",
                newName: "ReservaCodReserva");

            migrationBuilder.AlterColumn<int>(
                name: "CodReserva",
                table: "tb_exemplar_emprestimo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "desc_exemplar",
                table: "tb_exemplar_emprestimo",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

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
    }
}
