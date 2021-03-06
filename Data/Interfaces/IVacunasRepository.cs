using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Models;

namespace GineSys.API.Data.Interfaces
{
    public interface IVacunasRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<Vacuna>> GetAll();
        Task<Vacuna> GetById(int id);
    }
}