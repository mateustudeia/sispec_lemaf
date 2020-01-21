using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sispec");

            migrationBuilder.CreateTable(
                name: "Locais",
                schema: "sispec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Nome = table.Column<string>(nullable: true),
                    Capacidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pessoa",
                schema: "sispec",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(nullable: false),
                    cpf = table.Column<string>(nullable: false),
                    contato = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    data_nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pessoa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                schema: "sispec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tema = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    IdLocal = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: true),
                    DataFim = table.Column<DateTime>(nullable: true),
                    TempoDuracao = table.Column<DateTime>(nullable: true),
                    PreRequisitos = table.Column<string>(nullable: true),
                    FerramentasUtilizadas = table.Column<string>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: true),
                    Entreterimento_DataInicio = table.Column<DateTime>(nullable: true),
                    Entreterimento_DataFim = table.Column<DateTime>(nullable: true),
                    Entreterimento_IdPessoa = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: true),
                    tempoDuracao = table.Column<DateTime>(nullable: true),
                    Palestra_IdPessoa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evento_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_pessoa_Entreterimento_IdPessoa",
                        column: x => x.Entreterimento_IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_Locais_IdLocal",
                        column: x => x.IdLocal,
                        principalSchema: "sispec",
                        principalTable: "Locais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evento_pessoa_Palestra_IdPessoa",
                        column: x => x.Palestra_IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InscritoEvento",
                schema: "sispec",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscritoEvento", x => new { x.IdPessoa, x.IdEvento });
                    table.ForeignKey(
                        name: "FK_InscritoEvento_Evento_IdEvento",
                        column: x => x.IdEvento,
                        principalSchema: "sispec",
                        principalTable: "Evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscritoEvento_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdPessoa",
                schema: "sispec",
                table: "Evento",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Entreterimento_IdPessoa",
                schema: "sispec",
                table: "Evento",
                column: "Entreterimento_IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdLocal",
                schema: "sispec",
                table: "Evento",
                column: "IdLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_Palestra_IdPessoa",
                schema: "sispec",
                table: "Evento",
                column: "Palestra_IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_InscritoEvento_IdEvento",
                schema: "sispec",
                table: "InscritoEvento",
                column: "IdEvento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InscritoEvento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "Evento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "pessoa",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "Locais",
                schema: "sispec");
        }
    }
}
