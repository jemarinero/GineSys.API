using System;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Nombre de usuario requerido")]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required(ErrorMessage="Nombre completo requerido")]
        [MaxLength(255)]
        public string NombreCompleto { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDoctor { get; set; }
        public byte[] PasswordHash {set; get; }
        public byte[] PasswordSalt { get; set; }
        public DateTime FechaCreacion { get; set; }
        [MaxLength(20)]
        public string UsuarioCreacion { get; set; }   
        public DateTime? FechaModificacion { get; set; }
        [MaxLength(20)]
        public string UsuarioMoficacion { get; set; }   
    }
}