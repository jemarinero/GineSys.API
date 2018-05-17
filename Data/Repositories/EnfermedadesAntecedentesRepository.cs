using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class EnfermedadesAntecedentesRepository : IEnfermedadesAntecedentesRepository
    {
        private readonly DataContext _context;
        public EnfermedadesAntecedentesRepository(DataContext context)
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

        public async Task<EnfermedadAntecedente> GetById(int id)
        {
            var data = await this._context.EnfermedadesAntecedentes.FirstOrDefaultAsync(o => o.Id == id);
            return data;
        }

        public async Task<IEnumerable<EnfermedadAntecedente>> GetAll()
        {
            var data = await this._context.EnfermedadesAntecedentes.ToListAsync();
            return data;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}