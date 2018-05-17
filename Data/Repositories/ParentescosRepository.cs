using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class ParentescosRepository : IParentescosRepository
    {
        private readonly DataContext _context;
        public ParentescosRepository(DataContext context)
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

        public async Task<Parentesco> GetById(int id)
        {
            var parentesco = await this._context.Parentescos.FirstOrDefaultAsync(o => o.Id == id);
            return parentesco;
        }

        public async Task<IEnumerable<Parentesco>> GetAll()
        {
            var parentescos = await this._context.Parentescos.ToListAsync();
            return parentescos;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}