using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Factura
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int FacturaId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
        public int PacienteId { get; set; }
        public DateTime? FechaFactura { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "El Monto debe estar en el rango de {1} y {2}.")]
        public float Monto { get; set; }
        public string? Aseguradora { get; set; }

        [ForeignKey("FacturaId")]
        public List<FacturaDetalle> Detalle { get; set; } = new List<FacturaDetalle> ();

        public Factura()
        {
            FechaFactura = DateTime.Now;
            PacienteId = 0;
            Monto = 0;
        }
    }
}