using System;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Nombre de usuario requerido")]
        public string Username { get; set; }
        [Required(ErrorMessage="Contraseña es requerida")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "La contraseña debe contener entre 4 y 8 caractares")]
        public string Password { get; set; } 
        [Required(ErrorMessage="Nombre completo requerido")]
        public string NombreCompleto { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDoctor { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }   
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioMoficacion { get; set; } 
         
    }
}