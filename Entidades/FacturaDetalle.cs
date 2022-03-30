using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleId { get; set; }
        public string? Procedimiento { get; set; }        
        public float Precio { get; set; }

    }
}