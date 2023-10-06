using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drugovich.Migrations
{
    public partial class VinculoClienteGrupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grupoid",
                table: "Clientes",
                type: "integer",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Grupoid",
                table: "Clientes",
                column: "Grupoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes",
                column: "Grupoid",
                principalTable: "Grupos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_Grupoid",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Grupoid",
                table: "Clientes");
        }
    }
}
