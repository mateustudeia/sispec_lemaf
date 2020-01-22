using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution_01 : Migration
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
                name: "Eventos",
                schema: "sispec",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tema = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    IdLocal = table.Column<int>(nullable: false),
                    IdTipo = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                    table.ForeignKey(
                        name: "FK_Eventos_Locais_IdLocal",
                        column: x => x.IdLocal,
                        principalSchema: "sispec",
                        principalTable: "Locais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                schema: "sispec",
                columns: table => new
                {
                    Curso_id = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    TempoDuracao = table.Column<DateTime>(nullable: false),
                    PreRequisitos = table.Column<string>(nullable: true),
                    FerramentasUtilizadas = table.Column<string>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Curso_id);
                    table.ForeignKey(
                        name: "FK_Cursos_Eventos_Curso_id",
                        column: x => x.Curso_id,
                        principalSchema: "sispec",
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursos_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entreterimentos",
                schema: "sispec",
                columns: table => new
                {
                    EntreterimentoId = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreterimentos", x => x.EntreterimentoId);
                    table.ForeignKey(
                        name: "FK_Entreterimentos_Eventos_EntreterimentoId",
                        column: x => x.EntreterimentoId,
                        principalSchema: "sispec",
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Entreterimentos_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
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
                        name: "FK_InscritoEvento_Eventos_IdEvento",
                        column: x => x.IdEvento,
                        principalSchema: "sispec",
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscritoEvento_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Palestras",
                schema: "sispec",
                columns: table => new
                {
                    Palestra_id = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    tempoDuracao = table.Column<DateTime>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palestras", x => x.Palestra_id);
                    table.ForeignKey(
                        name: "FK_Palestras_Eventos_Palestra_id",
                        column: x => x.Palestra_id,
                        principalSchema: "sispec",
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Palestras_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_IdPessoa",
                schema: "sispec",
                table: "Cursos",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Entreterimentos_IdPessoa",
                schema: "sispec",
                table: "Entreterimentos",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_IdLocal",
                schema: "sispec",
                table: "Eventos",
                column: "IdLocal");

            migrationBuilder.CreateIndex(
                name: "IX_InscritoEvento_IdEvento",
                schema: "sispec",
                table: "InscritoEvento",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Palestras_IdPessoa",
                schema: "sispec",
                table: "Palestras",
                column: "IdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cursos",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "Entreterimentos",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "InscritoEvento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "Palestras",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "Eventos",
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
