using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}