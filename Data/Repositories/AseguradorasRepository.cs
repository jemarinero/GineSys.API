using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class AseguradorasRepository : IAseguradorasRepository
    {
        private readonly DataContext _context;
        public AseguradorasRepository(DataContext context)
        {
            this._context = context;

        }

        public void Add<T>(T entity) where T : class
        {
            this._context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            this._context.Remove(entity);
        }

        public async Task<Aseguradora> GetAseguradora(int id)
        {
            var aseguradora = await this._context.Aseguradoras.FirstOrDefaultAsync(o => o.Id == id);
            return aseguradora;
        }

        public async Task<IEnumerable<Aseguradora>> GetAseguradoras()
        {
            var aseguradoras = await this._context.Aseguradoras.ToListAsync();
            return aseguradoras;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            this._context.Update(entity);
        }
    }
}