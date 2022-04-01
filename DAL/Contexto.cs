using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Procedimiento> Procedimiento { get; set; }
        public DbSet<Aseguradora> Aseguradora { get; set; }      
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 1,
                Nombre = "Senasa"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 2,
                Nombre = "Humano"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 3,
                Nombre = "Seguros Universal"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 4,
                Nombre = "Reservas"
            });
            
            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 5,
                Nombre = "Mapfre BHD"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 6,
                Nombre = "La Monumental"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 7,
                Nombre = "Mapfre BHD"
            });

            modelBuilder.Entity<Aseguradora>().HasData(new Aseguradora
            {
                AseguradoraId = 8,
                Nombre = "La Monumental"
            });
        }
    }
}