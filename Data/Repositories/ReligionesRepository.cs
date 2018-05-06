using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class ReligionesRepository : IReligionesRepository
    {
        private readonly DataContext _context;
        public ReligionesRepository(DataContext context)
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

        public async Task<Religion> GetReligion(int id)
        {
            var religion = await this._context.Religiones.FirstOrDefaultAsync(o => o.Id == id);
            return religion;
        }

        public async Task<IEnumerable<Religion>> GetReligiones()
        {
            var religiones = await this._context.Religiones.ToListAsync();
            return religiones;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}