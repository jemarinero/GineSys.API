using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Models
{
    public class Aseguradora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength(255)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Direccion es requerido")]
        [MaxLength(255)]
        public string Direccion { get; set; }
        [MaxLength(20)]
        public string TelefonoFijo { get; set; }
        [MaxLength(20)]
        public string Fax { get; set; }
        [MaxLength(20)]
        public string TelefonoMovil { get; set; }
        [MaxLength(255)]
        public string Correo { get; set; }
        [MaxLength(255)]
        public string Contacto { get; set; }
        [MaxLength(20)]
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        [MaxLength(20)]
        public string UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

    }
}