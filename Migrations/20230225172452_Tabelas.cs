using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Soft.Migrations
{
    
    public partial class Tabelas : Migration
    {
       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Fantasia = table.Column<string>(type: "text", nullable: false),
                    Documento = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Usuario = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Venda = table.Column<double>(type: "double precision", nullable: false),
                    PesoBruto = table.Column<double>(type: "double precision", nullable: false),
                    PesoLiquido = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

       
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
