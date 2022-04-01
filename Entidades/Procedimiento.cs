using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Procedimiento
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int ProcedimientoId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        public string? Descripcion { get; set; }                

        [Range(1, int.MaxValue, ErrorMessage = "El precio debe estar en el rango de {1} y {2}.")]
        public float Precio { get; set; }
    }
}