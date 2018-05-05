﻿// <auto-generated />
using GineSys.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GineSys.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180504200051_ReligionesTable")]
    partial class ReligionesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GineSys.API.Models.Ocupacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioModificacion");

                    b.HasKey("Id");

                    b.ToTable("Ocupaciones");
                });

            modelBuilder.Entity("GineSys.API.Models.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioModificacion");

                    b.HasKey("Id");

                    b.ToTable("Religiones");
                });

            modelBuilder.Entity("GineSys.API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDoctor");

                    b.Property<string>("NombreCompleto")
                        .IsRequired();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<string>("UsuarioCreacion");

                    b.Property<string>("UsuarioMoficacion");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
