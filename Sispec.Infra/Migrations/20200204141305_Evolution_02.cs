using Microsoft.EntityFrameworkCore.Migrations;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_curso_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "curso");

            migrationBuilder.DropForeignKey(
                name: "FK_entreterimento_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "entreterimento");

            migrationBuilder.DropForeignKey(
                name: "FK_pelestra_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "pelestra");

            migrationBuilder.RenameColumn(
                name: "IdPessoa",
                schema: "sisEpec",
                table: "pelestra",
                newName: "Palestrante");

            migrationBuilder.RenameIndex(
                name: "IX_pelestra_IdPessoa",
                schema: "sisEpec",
                table: "pelestra",
                newName: "IX_pelestra_Palestrante");

            migrationBuilder.RenameColumn(
                name: "IdPessoa",
                schema: "sisEpec",
                table: "entreterimento",
                newName: "Organizador");

            migrationBuilder.RenameIndex(
                name: "IX_entreterimento_IdPessoa",
                schema: "sisEpec",
                table: "entreterimento",
                newName: "IX_entreterimento_Organizador");

            migrationBuilder.RenameColumn(
                name: "IdPessoa",
                schema: "sisEpec",
                table: "curso",
                newName: "Orientador");

            migrationBuilder.RenameIndex(
                name: "IX_curso_IdPessoa",
                schema: "sisEpec",
                table: "curso",
                newName: "IX_curso_Orientador");

            migrationBuilder.AddForeignKey(
                name: "FK_curso_pessoa_Orientador",
                schema: "sisEpec",
                table: "curso",
                column: "Orientador",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_entreterimento_pessoa_Organizador",
                schema: "sisEpec",
                table: "entreterimento",
                column: "Organizador",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pelestra_pessoa_Palestrante",
                schema: "sisEpec",
                table: "pelestra",
                column: "Palestrante",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_curso_pessoa_Orientador",
                schema: "sisEpec",
                table: "curso");

            migrationBuilder.DropForeignKey(
                name: "FK_entreterimento_pessoa_Organizador",
                schema: "sisEpec",
                table: "entreterimento");

            migrationBuilder.DropForeignKey(
                name: "FK_pelestra_pessoa_Palestrante",
                schema: "sisEpec",
                table: "pelestra");

            migrationBuilder.RenameColumn(
                name: "Palestrante",
                schema: "sisEpec",
                table: "pelestra",
                newName: "IdPessoa");

            migrationBuilder.RenameIndex(
                name: "IX_pelestra_Palestrante",
                schema: "sisEpec",
                table: "pelestra",
                newName: "IX_pelestra_IdPessoa");

            migrationBuilder.RenameColumn(
                name: "Organizador",
                schema: "sisEpec",
                table: "entreterimento",
                newName: "IdPessoa");

            migrationBuilder.RenameIndex(
                name: "IX_entreterimento_Organizador",
                schema: "sisEpec",
                table: "entreterimento",
                newName: "IX_entreterimento_IdPessoa");

            migrationBuilder.RenameColumn(
                name: "Orientador",
                schema: "sisEpec",
                table: "curso",
                newName: "IdPessoa");

            migrationBuilder.RenameIndex(
                name: "IX_curso_Orientador",
                schema: "sisEpec",
                table: "curso",
                newName: "IX_curso_IdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_curso_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "curso",
                column: "IdPessoa",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_entreterimento_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "entreterimento",
                column: "IdPessoa",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pelestra_pessoa_IdPessoa",
                schema: "sisEpec",
                table: "pelestra",
                column: "IdPessoa",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
