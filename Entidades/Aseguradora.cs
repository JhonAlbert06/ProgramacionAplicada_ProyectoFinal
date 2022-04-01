using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Aseguradora
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int AseguradoraId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        public string? Nombre { get; set; }
    }
}