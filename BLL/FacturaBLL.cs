using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.DAL;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.BLL
{
    public class FacturaBLL
    {
        private Contexto _contexto;

        public FacturaBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Factura factura)
        {
            if (!Existe(factura.FacturaId))
                return Insertar(factura);
            else
                return Modificar(factura);
        }

        private bool Insertar(Factura factura)
        {
            bool paso = false;

            try
            {
                if (_contexto.Facturas.Add(factura) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Factura factura)
        {
            bool paso = false;

            try
            {
                _contexto.Database.ExecuteSqlRaw($"DELETE FROM Detalle WHERE FacturaId={factura.PacienteId}");

                foreach (var Anterior in factura.Detalle)
                {
                    _contexto.Entry(Anterior).State = EntityState.Added;
                }

                _contexto.Entry(factura).State = EntityState.Modified;

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Eliminar(int Id)
        {
            bool paso = false;

            try
            {
                var factura = _contexto.Facturas.Find(Id);

                if (factura != null)
                {
                    _contexto.Facturas.Remove(factura);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public Factura Buscar(int Id)
        {
            Factura factura;

            try
            {
                factura = _contexto.Facturas
                    .Include(x => x.Detalle)
                    .Where(p => p.FacturaId == Id)
                    .AsNoTracking()
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return factura;
        }

        public bool Existe(int Id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Facturas.Any(p => p.FacturaId == Id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        
        public List<Factura> GetList(Expression<Func<Factura, bool>> critero)
        {
            List<Factura> lista = new List<Factura>();

            try
            {
                lista = _contexto.Facturas
                    .Include(x => x.Detalle)
                    .Where(critero)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
       
    }
}