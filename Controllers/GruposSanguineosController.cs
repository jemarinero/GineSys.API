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
    public class GruposSanguineosController : Controller
    {
        private readonly IGruposSanguineosRepository _repo;
        private readonly IMapper _mapper;
        public GruposSanguineosController(IGruposSanguineosRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var gruposSanguineos = await _repo.GetAll();
            return Ok(gruposSanguineos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var grupoSanguineo = await _repo.GetById(id);

            return Ok(grupoSanguineo);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GrupoSanguineoToCreateDto grupoSanguineoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var grupoSanguineoToCreate = _mapper.Map<GrupoSanguineo>(grupoSanguineoDto);
            _repo.Add(grupoSanguineoToCreate);
            await _repo.SaveAll();

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]GrupoSanguineoToUpdateDto grupoSanguineoToUpdateDto)
        {
            if (id != grupoSanguineoToUpdateDto.Id)
                ModelState.AddModelError("Id", "El grupo sanguineo a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var grupoSanguineoToUpdate = _mapper.Map<GrupoSanguineo>(grupoSanguineoToUpdateDto);

            _repo.Update(grupoSanguineoToUpdate);
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