using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Models
{
    public class GrupoSanguineo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(255)]
        public string Descripcion { get; set; }
        [MaxLength(20)]
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        [MaxLength(20)]
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}