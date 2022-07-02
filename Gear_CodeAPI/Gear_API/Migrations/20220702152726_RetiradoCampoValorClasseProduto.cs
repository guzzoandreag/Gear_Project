using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gear_API.Migrations
{
    public partial class RetiradoCampoValorClasseProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pro_valorcusto",
                table: "Produtos_00");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Pro_valorcusto",
                table: "Produtos_00",
                type: "decimal(18,10)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
