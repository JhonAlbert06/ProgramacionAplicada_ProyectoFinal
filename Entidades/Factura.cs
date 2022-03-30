using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public int PacienteId { get; set; }
        public DateTime? FechaFactura { get; set; }
        public float Monto { get; set; }
        public string? Aseguradora { get; set; }

        [ForeignKey("FacturaId")]
        public List<FacturaDetalle> Detalle { get; set; } = new List<FacturaDetalle> ();
    }
}