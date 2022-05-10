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
                    Dep_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dep_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposito_00", x => x.Dep_code);
                });

            migrationBuilder.CreateTable(
                name: "Estoque_00",
                columns: table => new
                {
                    Etq_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etq_quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dep_code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque_00", x => x.Etq_code);
                });

            migrationBuilder.CreateTable(
                name: "Produtos_00",
                columns: table => new
                {
                    Pro_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Pro_value = table.Column<double>(type: "float", nullable: false),
                    Etq_code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos_00", x => x.Pro_code);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Use_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Use_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Use_email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Usu_password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Use_code);
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
