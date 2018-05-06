using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Models;

namespace GineSys.API.Data.Interfaces
{
    public interface IReligionesRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<Religion>> GetReligiones();
        Task<Religion> GetReligion(int id);
    }
}