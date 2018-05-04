using System;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Nombre de usuario requerido")]
        public string Username { get; set; }
        [Required(ErrorMessage="Nombre completo requerido")]
        public string NombreCompleto { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDoctor { get; set; }
        public byte[] PasswordHash {set; get; }
        public byte[] PasswordSalt { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }   
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioMoficacion { get; set; }   
    }
}