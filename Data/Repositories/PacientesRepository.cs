using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Data.Repositories
{
    public class PacientesRepository : IPacientesRepository
    {
        private readonly DataContext _context;
        public PacientesRepository(DataContext context)
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

        public async Task<Paciente> GetById(int id)
        {
            var paciente = await this._context.Pacientes.FirstOrDefaultAsync(o => o.Id == id);
            return paciente;
        }

        public async Task<IEnumerable<Paciente>> GetAll()
        {
            var pacientes = await this._context.Pacientes.ToListAsync();
            return pacientes;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}