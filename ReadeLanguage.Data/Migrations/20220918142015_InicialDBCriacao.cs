using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReadeLanguage.Data.Migrations
{
    public partial class InicialDBCriacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Palavras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalavraPt = table.Column<string>(type: "varchar(200)", nullable: false),
                    IdTraducaoFr = table.Column<int>(type: "int", nullable: true),
                    IdTraducaoEn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palavras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalavrasFrances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalavraFr = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalavrasFrances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PalavrasIngles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PalavraEn = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PalavrasIngles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Palavras");

            migrationBuilder.DropTable(
                name: "PalavrasFrances");

            migrationBuilder.DropTable(
                name: "PalavrasIngles");
        }
    }
}
