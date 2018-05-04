using System.Threading.Tasks;
using GineSys.API.Data;
using GineSys.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;
using GineSys.API.Models;

namespace GineSys.API.Controllers 
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            this._config = config;
            this._repo = repo;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UsuarioDto usuarioDto)
        {
            if(!string.IsNullOrEmpty(usuarioDto.Username))
                usuarioDto.Username = usuarioDto.Username.ToLower();
            
            if(await _repo.UserExists(usuarioDto.Username))
                ModelState.AddModelError("Usuario","Usuario ya existe");
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var userToCreate = new Usuario
            {
                Username = usuarioDto.Username,
                NombreCompleto = usuarioDto.NombreCompleto,
                IsAdmin = usuarioDto.IsAdmin,
                IsDoctor = usuarioDto.IsDoctor,
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = usuarioDto.UsuarioCreacion
            };

            var createdUser = await _repo.Register(userToCreate, usuarioDto.Password);

            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repo.Login(userForLoginDto.Username.ToLower(), userForLoginDto.Password);

            if (userFromRepo == null)
                return Unauthorized();

            //generate token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:Token").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                    new Claim(ClaimTypes.Name, userFromRepo.Username)
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { tokenString });
        }
    }
}