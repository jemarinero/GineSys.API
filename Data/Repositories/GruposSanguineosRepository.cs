using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class GruposSanguineosRepository : IGruposSanguineosRepository
    {
        private readonly DataContext _context;
        public GruposSanguineosRepository(DataContext context)
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

        public async Task<GrupoSanguineo> GetById(int id)
        {
            var grupoSanguineo = await this._context.GruposSanguineos.FirstOrDefaultAsync(o => o.Id == id);
            return grupoSanguineo;
        }

        public async Task<IEnumerable<GrupoSanguineo>> GetAll()
        {
            var gruposSanguineos = await this._context.GruposSanguineos.ToListAsync();
            return gruposSanguineos;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}