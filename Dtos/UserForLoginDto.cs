using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Dtos
{
    public class UserForLoginDto
    {
        [Required(ErrorMessage="Nombre de usuario requerido")]
        public string Username { get; set; }
        [Required(ErrorMessage="Contraseña es requerida")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "La contraseña debe contener entre 4 y 8 caractares")]
        public string Password { get; set; }    
    }
}