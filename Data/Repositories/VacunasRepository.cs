using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class VacunasRepository : IVacunasRepository
    {
        private readonly DataContext _context;
        public VacunasRepository(DataContext context)
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

        public async Task<Vacuna> GetById(int id)
        {
            var data = await this._context.Vacunas.FirstOrDefaultAsync(o => o.Id == id);
            return data;
        }

        public async Task<IEnumerable<Vacuna>> GetAll()
        {
            var data = await this._context.Vacunas.ToListAsync();
            return data;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}