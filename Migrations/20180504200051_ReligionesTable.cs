using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class ReligionesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Religiones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    UsuarioCreacion = table.Column<string>(nullable: true),
                    UsuarioModificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religiones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Religiones");
        }
    }
}
