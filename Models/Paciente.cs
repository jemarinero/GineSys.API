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

        public string NombreConyugue { get; set; }

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
        //antecedentes gineco obstetricia
        public int EdadMenarca { get; set; }
        public string FrecuenciaMenstrual { get; set; }
        public int DiasMenstruacion { get; set; }
        public int CantidadMenstruacion { get; set; }
        public int EdadMenopausia { get; set; }
        public int EdadPrimeraRelacionSexual { get; set; }
        public bool isAlergica { get; set; }
        public string MedicamentosAlergica { get; set; }
        public bool hasCirugiaPrevia { get; set; }
        public string Cirugias { get; set; }
        public bool isPlanificando { get; set; }
        public string MetodoPlanificacion { get; set; }
        public DateTime? FechaUltimaCitologia { get; set; }
        public int CantidadEmbarazos { get; set; }
        public int CantidadHijosVivos { get; set; }
        public int CantidadHijosMuertos { get; set; }
        public int CantidadCesareas { get; set; }
        public int CantidadPartosVaginales { get; set; }
        public int CantidadObitos { get; set; }
        public int CantidadEctopicos { get; set; }
        public int CantidadMolas { get; set; }
        public int CantidadAbortos { get; set; }
        public DateTime? FechaUltimaCesarea { get; set; }
        public DateTime? FechaUltimoEmbarazo { get; set; }
        public int TerminoUltimoEmbarazo { get; set; }
        public bool hasLegrados { get; set; }
    }
}