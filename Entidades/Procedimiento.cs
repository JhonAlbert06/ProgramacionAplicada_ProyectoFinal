using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class Procedimiento
    {
        [Key]
        public int ProcedimientoId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }                
        public float Precio { get; set; }
    }
}