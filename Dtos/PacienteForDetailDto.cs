using System;

namespace GineSys.API.Dtos
{
    public class PacienteForDetailDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroIdentidad { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime? FechaUltMenstruacion { get; set; }
        public int? EstadoCivil { get; set; }
        public string Telefono { get; set; }
        public bool? hasSeguroMedico { get; set; }
        public string Correo { get; set; }
        public int? OcupacionId { get; set; }
        public string NombreConyugue { get; set; }
        public int? OcupacionIdConyugue { get; set; }
        public int? ReligionId { get; set; }
        public int? AseguradoraId { get; set; }
        public int? GrupoSanguineoId { get; set; }
        public byte[] Foto { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
    }
}