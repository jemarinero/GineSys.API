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
    public class AseguradorasController : Controller
    {
        private readonly IAseguradorasRepository _repo;
        private readonly IMapper _mapper;
        public AseguradorasController(IAseguradorasRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetAseguradoras()
        {
            var aseguradoras = await _repo.GetAseguradoras();
            return Ok(aseguradoras);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAseguradora(int id)
        {
            var aseguradora = await _repo.GetAseguradora(id);

            return Ok(aseguradora);
        }

        [HttpPost]
        public async Task<IActionResult> PostAseguradora([FromBody]AseguradoraToCreateDto aseguradoraToCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var aseguradoraToCreate = _mapper.Map<Aseguradora>(aseguradoraToCreateDto);
            _repo.Add(aseguradoraToCreate);
            await _repo.SaveAll();

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAseguradora(int id, [FromBody]AseguradoraToUpdateDto aseguradoraToUpdateDto)
        {
            if (id != aseguradoraToUpdateDto.Id)
                ModelState.AddModelError("Id", "La aseguradora a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var aseguradoraToUpdate = _mapper.Map<Aseguradora>(aseguradoraToUpdateDto);

            _repo.Update(aseguradoraToUpdate);
            await _repo.SaveAll();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAseguradora(int id)
        {
            var aseguradoraToDelete = await this._repo.GetAseguradora(id);
            this._repo.Delete(aseguradoraToDelete);
            await this._repo.SaveAll();

            return Ok();
        }
    }
}