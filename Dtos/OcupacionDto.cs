using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Dtos
{
    public class OcupacionDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Descripcion es requerido")]
        public string Descripcion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}