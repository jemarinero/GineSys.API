using System;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Dtos
{
    public class ReligionToCreateDto
    {
        [Required(ErrorMessage = "Descripcion es requerido")]
        public string Descripcion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}