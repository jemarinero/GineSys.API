using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class OcupacionesRepository : IOcupacionesRepository
    {
        private readonly DataContext _context;
        public OcupacionesRepository(DataContext context)
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

        public void Update<T>(T entity) where T : class
        {
            this._context.Update(entity);
        }

        public async Task<Ocupacion> GetOcupacion(int id)
        {
            var ocupacion = await this._context.Ocupaciones.FirstOrDefaultAsync(o => o.Id == id);
            return ocupacion;
        }

        public async Task<IEnumerable<Ocupacion>> GetOcupaciones()
        {
            var ocupaciones = await this._context.Ocupaciones.ToListAsync();
            return ocupaciones;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        
    }
}