using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Procedimiento
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int ProcedimientoId { get; set; }
        
        [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
        [MinLength(3, ErrorMessage = "El Nombre debe tener al menos {1} caractéres.")]
        [MaxLength(50, ErrorMessage = "EL Nombre no debe pasar de {1} caractéres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la descripcion")]
        [MinLength(3, ErrorMessage = "La Descripcion debe tener al menos {1} caractéres.")]
        [MaxLength(500, ErrorMessage = "La Descripcion no debe pasar de {1} caractéres.")]
        public string? Descripcion { get; set; }                

        [Range(1, int.MaxValue, ErrorMessage = "El precio debe estar en el rango de {1} y {2}.")]
        public float Precio { get; set; }

        public float TotalVendido { get; set; }
        public int CantidadVendido { get; set; }
    }
}