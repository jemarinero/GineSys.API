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
    [Migration("20180516204731_infoadicional")]
    partial class infoadicional
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GineSys.API.Models.Aseguradora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contacto")
                        .HasMaxLength(255);

                    b.Property<string>("Correo")
                        .HasMaxLength(255);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Fax")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("TelefonoFijo")
                        .HasMaxLength(20);

                    b.Property<string>("TelefonoMovil")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioModificacion")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Aseguradoras");
                });

            modelBuilder.Entity("GineSys.API.Models.GrupoSanguineo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioModificacion")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("GruposSanguineos");
                });

            modelBuilder.Entity("GineSys.API.Models.MotivoConsulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioModificacion")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("MotivosConsulta");
                });

            modelBuilder.Entity("GineSys.API.Models.Ocupacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioModificacion")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Ocupaciones");
                });

            modelBuilder.Entity("GineSys.API.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AseguradoraId");

                    b.Property<int>("CantidadAbortos");

                    b.Property<int>("CantidadCesareas");

                    b.Property<int>("CantidadEctopicos");

                    b.Property<int>("CantidadEmbarazos");

                    b.Property<int>("CantidadHijosMuertos");

                    b.Property<int>("CantidadHijosVivos");

                    b.Property<int>("CantidadMenstruacion");

                    b.Property<int>("CantidadMolas");

                    b.Property<int>("CantidadObitos");

                    b.Property<int>("CantidadPartosVaginales");

                    b.Property<string>("Cirugias");

                    b.Property<string>("Correo")
                        .HasMaxLength(80);

                    b.Property<int>("DiasMenstruacion");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255);

                    b.Property<int>("EdadMenarca");

                    b.Property<int>("EdadMenopausia");

                    b.Property<int>("EdadPrimeraRelacionSexual");

                    b.Property<bool>("Estado");

                    b.Property<int?>("EstadoCivil");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<DateTime?>("FechaUltMenstruacion");

                    b.Property<DateTime?>("FechaUltimaCesarea");

                    b.Property<DateTime?>("FechaUltimaCitologia");

                    b.Property<DateTime?>("FechaUltimoEmbarazo");

                    b.Property<byte[]>("Foto");

                    b.Property<string>("FrecuenciaMenstrual");

                    b.Property<int?>("GrupoSanguineoId");

                    b.Property<string>("MedicamentosAlergica");

                    b.Property<string>("MetodoPlanificacion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NombreConyugue");

                    b.Property<string>("NumeroIdentidad")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Observacion");

                    b.Property<int?>("OcupacionId");

                    b.Property<int?>("OcupacionIdConyugue");

                    b.Property<int?>("ReligionId");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20);

                    b.Property<bool>("hasCirugiaPrevia");

                    b.Property<bool>("hasLegrados");

                    b.Property<bool?>("hasSeguroMedico");

                    b.Property<bool>("hasUltimoEmbarazoTerminado");

                    b.Property<bool>("isAlergica");

                    b.Property<bool>("isPlanificando");

                    b.HasKey("Id");

                    b.HasIndex("AseguradoraId");

                    b.HasIndex("GrupoSanguineoId");

                    b.HasIndex("OcupacionId");

                    b.HasIndex("OcupacionIdConyugue");

                    b.HasIndex("ReligionId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("GineSys.API.Models.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime?>("FechaCreacion");

                    b.Property<DateTime?>("FechaModificacion");

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioModificacion")
                        .HasMaxLength(20);

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
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioCreacion")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioMoficacion")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GineSys.API.Models.Paciente", b =>
                {
                    b.HasOne("GineSys.API.Models.Aseguradora", "Aseguradora")
                        .WithMany()
                        .HasForeignKey("AseguradoraId");

                    b.HasOne("GineSys.API.Models.GrupoSanguineo", "GrupoSanguineo")
                        .WithMany()
                        .HasForeignKey("GrupoSanguineoId");

                    b.HasOne("GineSys.API.Models.Ocupacion", "Ocupacion")
                        .WithMany("OcupacionPacientes")
                        .HasForeignKey("OcupacionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GineSys.API.Models.Ocupacion", "OcupacionConyugue")
                        .WithMany("OcupacionConyugues")
                        .HasForeignKey("OcupacionIdConyugue")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("GineSys.API.Models.Religion", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId");
                });
#pragma warning restore 612, 618
        }
    }
}
