using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sispec.Infra.Migrations
{
    public partial class Evolution_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tempoDuracao",
                schema: "sisEpec",
                table: "palestra",
                newName: "TempoDuracao");

            migrationBuilder.AlterColumn<string>(
                name: "TempoDuracao",
                schema: "sisEpec",
                table: "palestra",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TempoDuracao",
                schema: "sisEpec",
                table: "palestra",
                newName: "tempoDuracao");

            migrationBuilder.AlterColumn<DateTime>(
                name: "tempoDuracao",
                schema: "sisEpec",
                table: "palestra",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
