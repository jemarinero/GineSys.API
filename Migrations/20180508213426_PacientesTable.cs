using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class PacientesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AseguradoraId = table.Column<int>(nullable: true),
                    Correo = table.Column<string>(maxLength: 80, nullable: true),
                    Direccion = table.Column<string>(maxLength: 255, nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: true),
                    FechaUltMenstruacion = table.Column<DateTime>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    GrupoSanguineoId = table.Column<int>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    NombreCoyugue = table.Column<string>(nullable: true),
                    NumeroIdentidad = table.Column<string>(maxLength: 20, nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    OcupacionId = table.Column<int>(nullable: true),
                    OcupacionIdConyugue = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true),
                    Telefono = table.Column<string>(maxLength: 20, nullable: true),
                    hasSeguroMedico = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Aseguradoras_AseguradoraId",
                        column: x => x.AseguradoraId,
                        principalTable: "Aseguradoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_GruposSanguineos_GrupoSanguineoId",
                        column: x => x.GrupoSanguineoId,
                        principalTable: "GruposSanguineos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Ocupaciones_OcupacionId",
                        column: x => x.OcupacionId,
                        principalTable: "Ocupaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Ocupaciones_OcupacionIdConyugue",
                        column: x => x.OcupacionIdConyugue,
                        principalTable: "Ocupaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Religiones_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_AseguradoraId",
                table: "Pacientes",
                column: "AseguradoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_GrupoSanguineoId",
                table: "Pacientes",
                column: "GrupoSanguineoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_OcupacionId",
                table: "Pacientes",
                column: "OcupacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_OcupacionIdConyugue",
                table: "Pacientes",
                column: "OcupacionIdConyugue");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ReligionId",
                table: "Pacientes",
                column: "ReligionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
