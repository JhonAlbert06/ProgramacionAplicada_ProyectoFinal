using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Apellido")]
        public string? Apellido { get; set; }  

        [Required(ErrorMessage = "Es obligatorio introducir el Email")]
        public string? Email { get; set; }  

        [Required(ErrorMessage = "Es obligatorio introducir la Direccion")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Telefono")]
        public string? Telefono { get; set; }
        public int Edad { get; set; }

        [Required(ErrorMessage = "Se debe elegir un sexo")]
        // 1 Hombre  2 Mujer
        public int Sexo { get; set; }

        [Required(ErrorMessage = "Se debe elegir un estado civil")]
        // 1 Soltero  2 Casado
        public int EstadoCivil { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Cedula")]
        public string? Cedula { get; set; }

        public Paciente()
        {
            Edad = 0;
            EstadoCivil = 0;
        }
    }
}