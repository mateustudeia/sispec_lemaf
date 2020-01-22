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
                name: "local",
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
                    table.PrimaryKey("PK_local", x => x.Id);
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
                name: "tipo_evento",
                schema: "sispec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DescricaoTipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "evento",
                schema: "sispec",
                columns: table => new
                {
                    id_evento = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Tema = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    IdLocal = table.Column<int>(nullable: false),
                    IdTipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evento", x => x.id_evento);
                    table.ForeignKey(
                        name: "FK_evento_local_IdLocal",
                        column: x => x.IdLocal,
                        principalSchema: "sispec",
                        principalTable: "local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evento_tipo_evento_IdTipo",
                        column: x => x.IdTipo,
                        principalSchema: "sispec",
                        principalTable: "tipo_evento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "curso",
                schema: "sispec",
                columns: table => new
                {
                    curso_id = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    TempoDuracao = table.Column<DateTime>(nullable: false),
                    PreRequisitos = table.Column<string>(nullable: true),
                    FerramentasUtilizadas = table.Column<string>(nullable: true),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso", x => x.curso_id);
                    table.ForeignKey(
                        name: "FK_curso_evento_curso_id",
                        column: x => x.curso_id,
                        principalSchema: "sispec",
                        principalTable: "evento",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_curso_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entreterimento",
                schema: "sispec",
                columns: table => new
                {
                    id_entreterimento = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entreterimento", x => x.id_entreterimento);
                    table.ForeignKey(
                        name: "FK_entreterimento_evento_id_entreterimento",
                        column: x => x.id_entreterimento,
                        principalSchema: "sispec",
                        principalTable: "evento",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_entreterimento_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inscrito_evento",
                schema: "sispec",
                columns: table => new
                {
                    IdPessoa = table.Column<int>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscrito_evento", x => new { x.IdPessoa, x.IdEvento });
                    table.ForeignKey(
                        name: "FK_inscrito_evento_evento_IdEvento",
                        column: x => x.IdEvento,
                        principalSchema: "sispec",
                        principalTable: "evento",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inscrito_evento_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pelestra",
                schema: "sispec",
                columns: table => new
                {
                    palestra_id = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    tempoDuracao = table.Column<DateTime>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pelestra", x => x.palestra_id);
                    table.ForeignKey(
                        name: "FK_pelestra_evento_palestra_id",
                        column: x => x.palestra_id,
                        principalSchema: "sispec",
                        principalTable: "evento",
                        principalColumn: "id_evento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pelestra_pessoa_IdPessoa",
                        column: x => x.IdPessoa,
                        principalSchema: "sispec",
                        principalTable: "pessoa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_curso_IdPessoa",
                schema: "sispec",
                table: "curso",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_entreterimento_IdPessoa",
                schema: "sispec",
                table: "entreterimento",
                column: "IdPessoa");

            migrationBuilder.CreateIndex(
                name: "IX_evento_IdLocal",
                schema: "sispec",
                table: "evento",
                column: "IdLocal");

            migrationBuilder.CreateIndex(
                name: "IX_evento_IdTipo",
                schema: "sispec",
                table: "evento",
                column: "IdTipo");

            migrationBuilder.CreateIndex(
                name: "IX_inscrito_evento_IdEvento",
                schema: "sispec",
                table: "inscrito_evento",
                column: "IdEvento");

            migrationBuilder.CreateIndex(
                name: "IX_pelestra_IdPessoa",
                schema: "sispec",
                table: "pelestra",
                column: "IdPessoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "curso",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "entreterimento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "inscrito_evento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "pelestra",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "evento",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "pessoa",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "local",
                schema: "sispec");

            migrationBuilder.DropTable(
                name: "tipo_evento",
                schema: "sispec");
        }
    }
}
