using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gear_API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deposito_00",
                columns: table => new
                {
                    Dep_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dep_nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dep_tipocadastro = table.Column<int>(type: "int", nullable: false),
                    Dep_tipoplantio = table.Column<int>(type: "int", nullable: true),
                    Dep_tamanhofazenda = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposito_00", x => x.Dep_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Estoque_00",
                columns: table => new
                {
                    Etq_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etq_quantidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etq_validade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dep_codigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque_00", x => x.Etq_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Produtos_00",
                columns: table => new
                {
                    Pro_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Pro_valorcusto = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Pro_Medida = table.Column<double>(type: "float", nullable: false),
                    Pro_Grupo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos_00", x => x.Pro_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Use_codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Use_nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Use_email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Usu_senha = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Use_codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deposito_00");

            migrationBuilder.DropTable(
                name: "Estoque_00");

            migrationBuilder.DropTable(
                name: "Produtos_00");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
