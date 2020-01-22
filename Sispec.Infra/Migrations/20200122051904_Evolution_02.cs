using Microsoft.EntityFrameworkCore.Migrations;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_pessoa_IdPessoa",
                schema: "sispec",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Entreterimentos_pessoa_IdPessoa",
                schema: "sispec",
                table: "Entreterimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_InscritoEvento_pessoa_IdPessoa",
                schema: "sispec",
                table: "InscritoEvento");

            migrationBuilder.DropForeignKey(
                name: "FK_Palestras_pessoa_IdPessoa",
                schema: "sispec",
                table: "Palestras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pessoa",
                schema: "sispec",
                table: "pessoa");

            migrationBuilder.RenameTable(
                name: "pessoa",
                schema: "sispec",
                newName: "Pessoa",
                newSchema: "sispec");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                schema: "sispec",
                table: "Pessoa",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Cursos",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entreterimentos_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Entreterimentos",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InscritoEvento_Pessoa_IdPessoa",
                schema: "sispec",
                table: "InscritoEvento",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Palestras_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Palestras",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Entreterimentos_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Entreterimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_InscritoEvento_Pessoa_IdPessoa",
                schema: "sispec",
                table: "InscritoEvento");

            migrationBuilder.DropForeignKey(
                name: "FK_Palestras_Pessoa_IdPessoa",
                schema: "sispec",
                table: "Palestras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                schema: "sispec",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                schema: "sispec",
                newName: "pessoa",
                newSchema: "sispec");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pessoa",
                schema: "sispec",
                table: "pessoa",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_pessoa_IdPessoa",
                schema: "sispec",
                table: "Cursos",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entreterimentos_pessoa_IdPessoa",
                schema: "sispec",
                table: "Entreterimentos",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InscritoEvento_pessoa_IdPessoa",
                schema: "sispec",
                table: "InscritoEvento",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Palestras_pessoa_IdPessoa",
                schema: "sispec",
                table: "Palestras",
                column: "IdPessoa",
                principalSchema: "sispec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
