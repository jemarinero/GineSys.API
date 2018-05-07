using System.Threading.Tasks;
using AutoMapper;
using GineSys.API.Data;
using GineSys.API.Data.Interfaces;
using GineSys.API.Dtos;
using GineSys.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GineSys.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ReligionesController : Controller
    {
        private readonly IReligionesRepository _repo;
        private readonly IMapper _mapper;
        public ReligionesController(IReligionesRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetReligiones()
        {
            var religiones = await _repo.GetReligiones();
            return Ok(religiones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReligion(int id)
        {
            var religion = await _repo.GetReligion(id);

            return Ok(religion);
        }

        [HttpPost]
        public async Task<IActionResult> PostReligion([FromBody]ReligionToCreateDto religionToCreateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var religionToCreate = _mapper.Map<Religion>(religionToCreateDto);
            _repo.Add(religionToCreate);
            await _repo.SaveAll();

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReligion(int id, [FromBody]ReligionToUpdateDto religionToUpdateDto)
        {
            if (id != religionToUpdateDto.Id)
                ModelState.AddModelError("Id", "La religion a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var religionToUpdate = _mapper.Map<Religion>(religionToUpdateDto);

            _repo.Update(religionToUpdate);
            await _repo.SaveAll();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReligion(int id)
        {
            var religionToDelete = await this._repo.GetReligion(id);
            this._repo.Delete(religionToDelete);
            await this._repo.SaveAll();

            return Ok();
        }
    }
}