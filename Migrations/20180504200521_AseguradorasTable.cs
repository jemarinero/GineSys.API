using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class AseguradorasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aseguradoras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contacto = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    TelefonoFijo = table.Column<string>(nullable: true),
                    TelefonoMovil = table.Column<string>(nullable: true),
                    UsuarioCreacion = table.Column<string>(nullable: true),
                    UsuarioModificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aseguradoras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aseguradoras");
        }
    }
}
