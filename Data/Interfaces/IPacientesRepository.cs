using System.Collections.Generic;
using System.Threading.Tasks;
using GineSys.API.Dtos;
using GineSys.API.Models;

namespace GineSys.API.Data.Interfaces
{
    public interface IPacientesRepository
    {
        Task<Paciente> Add(Paciente entity);
        void Delete<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<PacienteForListDto>> GetAll();
        Task<PacienteForDetailDto> GetByIdDto(int id);
        Task<Paciente> GetById(int id);
    }
}