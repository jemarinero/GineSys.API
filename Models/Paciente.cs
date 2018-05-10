using System;
using System.ComponentModel.DataAnnotations;

namespace GineSys.API.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(20)]
        public string NumeroIdentidad { get; set; }
        [MaxLength(255)]
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaUltMenstruacion { get; set; }
        public int? EstadoCivil { get; set; }
        [MaxLength(20)]
        public string Telefono { get; set; }
        public bool? hasSeguroMedico { get; set; }
        [MaxLength(80)]
        public string Correo { get; set; }
        
        public int? OcupacionId { get; set; }
        public Ocupacion Ocupacion { get; set; }

        public string NombreCoyugue { get; set; }

        public int? OcupacionIdConyugue { get; set; }
        public Ocupacion OcupacionConyugue { get; set; }

        public int? ReligionId { get; set; }
        public Religion Religion { get; set; }

        public int? AseguradoraId { get; set; }
        public Aseguradora Aseguradora { get; set; }

        public int? GrupoSanguineoId { get; set; }
        public GrupoSanguineo GrupoSanguineo { get; set; }

        public byte[] Foto { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
    }
}