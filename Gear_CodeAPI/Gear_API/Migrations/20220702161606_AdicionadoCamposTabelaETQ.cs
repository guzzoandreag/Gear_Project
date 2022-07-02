using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gear_API.Migrations
{
    public partial class AdicionadoCamposTabelaETQ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Etq_quantidade",
                table: "Estoque_00",
                type: "decimal(18,10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Etq_valorcusto",
                table: "Estoque_00",
                type: "decimal(18,10)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Pro_codigo",
                table: "Estoque_00",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Etq_valorcusto",
                table: "Estoque_00");

            migrationBuilder.DropColumn(
                name: "Pro_codigo",
                table: "Estoque_00");

            migrationBuilder.AlterColumn<string>(
                name: "Etq_quantidade",
                table: "Estoque_00",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)");
        }
    }
}
