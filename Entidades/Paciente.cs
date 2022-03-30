using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }  
        public string? Email { get; set; }  
        public string? Direccion { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }

        // 1 Soltero  2 Casado
        public int EstadoCivil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Cedula { get; set; }
    }
}