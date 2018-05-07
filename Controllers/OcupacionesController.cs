using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GineSys.API.Data;
using GineSys.API.Data.Interfaces;
using GineSys.API.Dtos;
using GineSys.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GineSys.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class OcupacionesController : Controller
    {
        private readonly IOcupacionesRepository _repo;
        private readonly IMapper _mapper;
        public OcupacionesController(IOcupacionesRepository repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetOcupaciones()
        {
            var ocupaciones = await _repo.GetOcupaciones();
            return Ok(ocupaciones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOcupacion(int id)
        {
            var ocupacion = await _repo.GetOcupacion(id);

            return Ok(ocupacion);
        }

        [HttpPost]
        public async Task<IActionResult> PostOcupacion([FromBody]OcupacionToCreateDto ocupacionDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var ocupacionToCreate = _mapper.Map<Ocupacion>(ocupacionDto);
            _repo.Add(ocupacionToCreate);
            await _repo.SaveAll();

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOcupacion(int id, [FromBody]OcupacionToUpdateDto ocupacionToUpdateDto)
        {
            if (id != ocupacionToUpdateDto.Id)
                ModelState.AddModelError("Id", "La ocupacion a modificar no existe");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var ocupacionToUpdate = _mapper.Map<Ocupacion>(ocupacionToUpdateDto);

            _repo.Update(ocupacionToUpdate);
            await _repo.SaveAll();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOcupacion(int id)
        {
            var ocupacionForDelete = await this._repo.GetOcupacion(id);
            this._repo.Delete(ocupacionForDelete);
            await this._repo.SaveAll();

            return Ok();
        }
    }
}