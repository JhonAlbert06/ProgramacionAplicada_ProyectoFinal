using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Procedimiento
    {
        [Key]
        public int ProcedimientoId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        public string? Descripcion { get; set; }                

        
        public float Precio { get; set; }
    }
}