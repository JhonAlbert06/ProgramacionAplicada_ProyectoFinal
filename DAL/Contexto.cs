using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Procedimiento> Procedimiento { get; set; }    
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}