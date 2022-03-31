using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class FacturaDetalle
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int FacturaDetalleId { get; set; }
        public int ProcedimientoId { get; set; }
        public string? Procedimiento { get; set; }        
        
        [Range(0, int.MaxValue, ErrorMessage = "El precio debe estar en el rango de {1} y {2}.")]
        public float Precio { get; set; }

    }
}