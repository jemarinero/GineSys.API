using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ocupacion> Ocupaciones { get; set; }
        public DbSet<Religion> Religiones { get; set; }
        public DbSet<Aseguradora> Aseguradoras { get; set; }
        public DbSet<GrupoSanguineo> GruposSanguineos { get; set; }
        public DbSet<MotivoConsulta> MotivosConsulta { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<EnfermedadAntecedente> EnfermedadesAntecedentes { get; set; }
        public DbSet<Parentesco> Parentescos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.Ocupacion)
                .WithMany(p => p.OcupacionPacientes)
                .HasForeignKey(p => p.OcupacionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.OcupacionConyugue)
                .WithMany(p => p.OcupacionConyugues)
                .HasForeignKey(p => p.OcupacionIdConyugue)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}