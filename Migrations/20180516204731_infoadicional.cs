using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class infoadicional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadAbortos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadCesareas",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadEctopicos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadEmbarazos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadHijosMuertos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadHijosVivos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadMolas",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadObitos",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadPartosVaginales",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaCesarea",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimaCitologia",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaUltimoEmbarazo",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hasLegrados",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasUltimoEmbarazoTerminado",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadAbortos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadCesareas",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadEctopicos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadEmbarazos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadHijosMuertos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadHijosVivos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadMolas",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadObitos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "CantidadPartosVaginales",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FechaUltimaCesarea",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FechaUltimaCitologia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FechaUltimoEmbarazo",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "hasLegrados",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "hasUltimoEmbarazoTerminado",
                table: "Pacientes");
        }
    }
}
