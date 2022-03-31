using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Procedimiento> Procedimientos { get; set; }
    
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}