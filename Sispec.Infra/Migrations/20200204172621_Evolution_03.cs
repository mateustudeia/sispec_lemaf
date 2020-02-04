using Microsoft.EntityFrameworkCore.Migrations;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pelestra_evento_palestra_id",
                schema: "sisEpec",
                table: "pelestra");

            migrationBuilder.DropForeignKey(
                name: "FK_pelestra_pessoa_Palestrante",
                schema: "sisEpec",
                table: "pelestra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pelestra",
                schema: "sisEpec",
                table: "pelestra");

            migrationBuilder.RenameTable(
                name: "pelestra",
                schema: "sisEpec",
                newName: "palestra",
                newSchema: "sisEpec");

            migrationBuilder.RenameIndex(
                name: "IX_pelestra_Palestrante",
                schema: "sisEpec",
                table: "palestra",
                newName: "IX_palestra_Palestrante");

            migrationBuilder.AddPrimaryKey(
                name: "PK_palestra",
                schema: "sisEpec",
                table: "palestra",
                column: "palestra_id");

            migrationBuilder.AddForeignKey(
                name: "FK_palestra_evento_palestra_id",
                schema: "sisEpec",
                table: "palestra",
                column: "palestra_id",
                principalSchema: "sisEpec",
                principalTable: "evento",
                principalColumn: "id_evento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_palestra_pessoa_Palestrante",
                schema: "sisEpec",
                table: "palestra",
                column: "Palestrante",
                principalSchema: "sisEpec",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_palestra_evento_palestra_id",
                schema: "sisEpec",
                table: "palestra");

            migrationBuilder.DropForeignKey(
                name: "FK_palestra_pessoa_Palestrante",
                schema: "sisEpec",
                table: "palestra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_palestra",
                schema: "sisEpec",
                table: "palestra");

            migrationBuilder.RenameTable(
                name: "palestra",
                schema: "sisEpec",
                newName: "pelestra",
                newSchema: "sisEpec");

            migrationBuilder.RenameIndex(
                name: "IX_palestra_Palestrante",
                schema: "sisEpec",
                table: "pelestra",
                newName: "IX_pelestra_Palestrante");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pelestra",
                schema: "sisEpec",
                table: "pelestra",
                column: "palestra_id");

            migrationBuilder.AddForeignKey(
                name: "FK_pelestra_evento_palestra_id",
                schema: "sisEpec",
                table: "pelestra",
                column: "palestra_id",
                principalSchema: "sisEpec",
                principalTable: "evento",
                principalColumn: "id_evento",
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
    }
}
