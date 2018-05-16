using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class pacientecolumnasgineobst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadMenstruacion",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cirugias",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiasMenstruacion",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EdadMenarca",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EdadMenopausia",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EdadPrimeraRelacionSexual",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FrecuenciaMenstrual",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicamentosAlergica",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetodoPlanificacion",
                table: "Pacientes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "hasCirugiaPrevia",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAlergica",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isPlanificando",
                table: "Pacientes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadMenstruacion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Cirugias",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DiasMenstruacion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EdadMenarca",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EdadMenopausia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EdadPrimeraRelacionSexual",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FrecuenciaMenstrual",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "MedicamentosAlergica",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "MetodoPlanificacion",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "hasCirugiaPrevia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "isAlergica",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "isPlanificando",
                table: "Pacientes");
        }
    }
}
