using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class MotivosConsultaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GruposSanguineos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 255, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: true),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposSanguineos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotivosConsulta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 255, nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    UsuarioCreacion = table.Column<string>(maxLength: 20, nullable: true),
                    UsuarioModificacion = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivosConsulta", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GruposSanguineos");

            migrationBuilder.DropTable(
                name: "MotivosConsulta");
        }
    }
}
