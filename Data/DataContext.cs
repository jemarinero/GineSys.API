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
    }
}