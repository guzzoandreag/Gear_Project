using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gear_API.Migrations
{
    public partial class AlteradoCampoValidadeParaDataLancamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etq_validade",
                table: "Estoque_00");

            migrationBuilder.AddColumn<DateTime>(
                name: "Etq_datalancamento",
                table: "Estoque_00",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etq_datalancamento",
                table: "Estoque_00");

            migrationBuilder.AddColumn<DateTime>(
                name: "Etq_validade",
                table: "Estoque_00",
                type: "datetime2",
                nullable: true);
        }
    }
}
