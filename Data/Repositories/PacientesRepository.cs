using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GineSys.API.Data.Interfaces;
using GineSys.API.Dtos;
using GineSys.API.Helpers;
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

        public async Task<PacienteForDetailDto> GetById(int id)
        {
            var paciente = await this._context.Pacientes.FirstOrDefaultAsync(o => o.Id == id);
            var pacienteForDetail = new PacienteForDetailDto() {
                Id = paciente.Id,
                Nombre = paciente.Nombre,
                NumeroIdentidad = paciente.NumeroIdentidad,
                Direccion = paciente.Direccion,
                FechaNacimiento = paciente.FechaNacimiento,
                Edad = paciente.FechaNacimiento.CalculateAge(),
                FechaUltMenstruacion = paciente.FechaUltMenstruacion,
                EstadoCivil = paciente.EstadoCivil,
                Telefono = paciente.Telefono,
                hasSeguroMedico = paciente.hasSeguroMedico,
                Correo = paciente.Correo,
                OcupacionId = paciente.OcupacionId,
                NombreConyugue = paciente.NombreConyugue,
                OcupacionIdConyugue = paciente.OcupacionIdConyugue,
                ReligionId = paciente.ReligionId,
                AseguradoraId = paciente.AseguradoraId,
                GrupoSanguineoId = paciente.GrupoSanguineoId,
                Foto = paciente.Foto,
                Observacion = paciente.Observacion,
                Estado = paciente.Estado,
                EdadMenarca = paciente.EdadMenarca,
                FrecuenciaMenstrual = paciente.FrecuenciaMenstrual,
                DiasMenstruacion = paciente.DiasMenstruacion,
                CantidadMenstruacion = paciente.CantidadMenstruacion,
                EdadMenopausia = paciente.EdadMenopausia,
                EdadPrimeraRelacionSexual = paciente.EdadPrimeraRelacionSexual,
                isAlergica = paciente.isAlergica,
                MedicamentosAlergica = paciente.MedicamentosAlergica,
                hasCirugiaPrevia = paciente.hasCirugiaPrevia,
                Cirugias = paciente.Cirugias,
                isPlanificando = paciente.isPlanificando,
                MetodoPlanificacion = paciente.MetodoPlanificacion,
                FechaUltimaCitologia = paciente.FechaUltimaCitologia,
                CantidadHijosVivos = paciente.CantidadHijosVivos,
                CantidadEmbarazos = paciente.CantidadEmbarazos,
                CantidadHijosMuertos = paciente.CantidadHijosMuertos,
                CantidadCesareas = paciente.CantidadCesareas,
                CantidadPartosVaginales = paciente.CantidadPartosVaginales,
                CantidadObitos = paciente.CantidadObitos,
                CantidadEctopicos = paciente.CantidadEctopicos,
                CantidadMolas = paciente.CantidadMolas,
                CantidadAbortos = paciente.CantidadAbortos,
                FechaUltimaCesarea = paciente.FechaUltimaCesarea,
                FechaUltimoEmbarazo = paciente.FechaUltimoEmbarazo,
                TerminoUltimoEmbarazo = paciente.TerminoUltimoEmbarazo,
                hasLegrados = paciente.hasLegrados
            };
            return pacienteForDetail;
        }

        public async Task<IEnumerable<PacienteForListDto>> GetAll()
        {
            var pacientes = await this._context.Pacientes.Select(p => new PacienteForListDto {
                Id = p.Id,
                Nombre = p.Nombre,
                Direccion = p.Direccion,
                FechaNacimiento = p.FechaNacimiento,
                Edad = p.FechaNacimiento.CalculateAge(),
                Telefono = p.Telefono,
                Correo = p.Correo,
                Estado = p.Estado,
            }).ToListAsync();

            return pacientes;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}