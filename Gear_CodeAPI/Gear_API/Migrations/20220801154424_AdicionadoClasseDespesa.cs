using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gear_API.Migrations
{
    public partial class AdicionadoClasseDespesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Despesa_00",
                columns: table => new
                {
                    Des_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Des_datalancamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dep_codigo = table.Column<int>(type: "int", nullable: false),
                    Des_valor = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Des_observacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despesa_00", x => x.Des_codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despesa_00");
        }
    }
}
