using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GineSys.API.Migrations
{
    public partial class DataAnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuarioMoficacion",
                table: "Usuarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Usuarios",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Usuarios",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Usuarios",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Religiones",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Religiones",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Religiones",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Ocupaciones",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Ocupaciones",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ocupaciones",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Aseguradoras",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Aseguradoras",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoMovil",
                table: "Aseguradoras",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoFijo",
                table: "Aseguradoras",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Aseguradoras",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "Aseguradoras",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Aseguradoras",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Aseguradoras",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contacto",
                table: "Aseguradoras",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuarioMoficacion",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "NombreCompleto",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Religiones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Religiones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Religiones",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Ocupaciones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Ocupaciones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Ocupaciones",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioModificacion",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioCreacion",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoMovil",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoFijo",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Aseguradoras",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Aseguradoras",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contacto",
                table: "Aseguradoras",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
