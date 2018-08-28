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
    public class VacunasController : Controller
    {
        private readonly IVacunasRepository _repo;
        private readonly IMapper _mapper;
        public VacunasController(IVacunasRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _repo.GetById(id);

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]VacunaToCreateDto param)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var data = _mapper.Map<Vacuna>(param);
            _repo.Add(data);
            await _repo.SaveAll();

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]VacunaToUpdateDto param)
        {
            if (id != param.Id)
                ModelState.AddModelError("Id", "El registro a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var data = _mapper.Map<Vacuna>(param);

            _repo.Update(data);
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