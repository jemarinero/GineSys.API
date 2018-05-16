using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class terminoultimoembarazo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hasUltimoEmbarazoTerminado",
                table: "Pacientes");

            migrationBuilder.AddColumn<int>(
                name: "TerminoUltimoEmbarazo",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TerminoUltimoEmbarazo",
                table: "Pacientes");

            migrationBuilder.AddColumn<bool>(
                name: "hasUltimoEmbarazoTerminado",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);
        }
    }
}
