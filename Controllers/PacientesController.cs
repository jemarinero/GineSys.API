using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GineSys.API.Data.Interfaces;
using GineSys.API.Dtos;
using GineSys.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GineSys.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class PacientesController : Controller
    {
        private readonly IPacientesRepository _repo;
        private readonly IMapper _mapper;
        public PacientesController(IPacientesRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pacientes = await _repo.GetAll();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pacientes = await _repo.GetByIdDto(id);

            return Ok(pacientes);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]PacienteForDetailDto pacienteDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var pacienteCreatedDto = _mapper.Map<Paciente>(pacienteDto);
            await _repo.Add(pacienteCreatedDto);

            return Ok(pacienteCreatedDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]PacienteForDetailDto pacienteDto)
        {
            if (id != pacienteDto.Id)
                ModelState.AddModelError("Id", "El paciente a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var pacientoToUpdate = _mapper.Map<Paciente>(pacienteDto);

            _repo.Update(pacientoToUpdate);
            await _repo.SaveAll();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var objectToDelete = await this._repo.GetById(id);
            this._repo.Delete(objectToDelete);
            await this._repo.SaveAll();

            return Ok();
        }
    }
}