using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Paciente
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        [MinLength(3, ErrorMessage = "El Nombre debe tener al menos {1} caractéres.")]
        [MaxLength(35, ErrorMessage = "El Nombre no debe pasar de {1} caractéres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Apellido")]
        [MinLength(3, ErrorMessage = "El Apellido debe tener al menos {1} caractéres.")]
        [MaxLength(35, ErrorMessage = "El Apellido no debe pasar de {1} caractéres.")]
        public string? Apellido { get; set; }  

        [Required(ErrorMessage = "Es obligatorio introducir el Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", 
        ErrorMessage = "El correo esta mal escrito")]
        public string? Email { get; set; }  

        [Required(ErrorMessage = "Es obligatorio introducir la Direccion")]
        [MinLength(3, ErrorMessage = "La Direccion debe tener al menos {1} caractéres.")]
        [MaxLength(50, ErrorMessage = "La Direccion no debe pasar de {1} caractéres.")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir el Telefono")]
        [MinLength(10, ErrorMessage = "El telefono debe tener al menos {1} caractéres.")]
        [MaxLength(15, ErrorMessage = "El telefono no debe pasar de {1} caractéres.")]
        [Phone]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Se debe elegir un sexo")]
        // 1 Hombre  2 Mujer
        public char Sexo { get; set; }

        [Required(ErrorMessage = "Se debe elegir un estado civil")]
        // 1 Soltero  2 Casado
        public string? EstadoCivil { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la fecha de Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la Cedula")]
        [MinLength(10, ErrorMessage = "La Cedula debe tener al menos {1} caractéres.")]
        [MaxLength(20, ErrorMessage = "La Cedula no debe pasar de {1} caractéres.")]
        public string? Cedula { get; set; }

    }
}