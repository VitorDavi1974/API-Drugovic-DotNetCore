using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drugovich.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "Grupoid",
                table: "Clientes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "Gerentes",
                columns: new[] { "id", "email", "nivel", "nome" },
                values: new object[,]
                {
                    { 1, "gerente1@gmail.com", 1, "Gerente 1" },
                    { 2, "gerente2@gmail.com", 2, "Gerente 2" },
                    { 3, "gerente3@gmail.com", 1, "Gerente 3" },
                    { 4, "gerente4@gmail.com", 2, "Gerente 4" },
                    { 5, "gerente5@gmail.com", 1, "Gerente 5" }
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "id", "nome" },
                values: new object[] { 1, "Grupo 1" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "id", "Grupoid", "cnpj", "fundacao", "nome" },
                values: new object[,]
                {
                    { 1, 1, "1234567890", new DateTime(2008, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 1" },
                    { 2, 1, "1234567891", new DateTime(2009, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 2" },
                    { 3, 1, "1234567892", new DateTime(2010, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 3" },
                    { 4, 1, "1234567893", new DateTime(2011, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 4" },
                    { 5, 1, "1234567894", new DateTime(2012, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 5" },
                    { 6, 1, "1234567895", new DateTime(2013, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 6" },
                    { 7, 1, "1234567896", new DateTime(2014, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 7" },
                    { 8, 1, "1234567897", new DateTime(2015, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 8" },
                    { 9, 1, "1234567898", new DateTime(2016, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 9" },
                    { 10, 1, "1234567899", new DateTime(2017, 12, 10, 12, 0, 0, 0, DateTimeKind.Utc), "Cliente 10" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes",
                column: "Grupoid",
                principalTable: "Grupos",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gerentes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gerentes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gerentes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gerentes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gerentes",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grupos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Grupoid",
                table: "Clientes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Grupos_Grupoid",
                table: "Clientes",
                column: "Grupoid",
                principalTable: "Grupos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
