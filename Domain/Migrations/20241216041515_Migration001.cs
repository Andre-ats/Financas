using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Financas.Migrations
{
    /// <inheritdoc />
    public partial class Migration001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TituloGasto = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    DescricaoGasto = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Estabelecimento = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    GastoDinheiro = table.Column<long>(type: "bigint", nullable: false),
                    DataGasto = table.Column<DateTime>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TituloReceita = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: true),
                    DescricaoReceita = table.Column<string>(type: "text", nullable: true),
                    Estabelecimento = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    ReceitaDinheiro = table.Column<long>(type: "bigint", nullable: false),
                    DataReceita = table.Column<DateTime>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: true),
                    ReceitaInicial = table.Column<long>(type: "bigint", nullable: false),
                    ReceitaAtual = table.Column<long>(type: "bigint", nullable: false),
                    DataDeCadastro = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
