using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.DAL;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.BLL
{
    public class ProcedimientoBLL
    {
        private Contexto _contexto;

        public ProcedimientoBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Procedimiento procedimiento)
        {
            if (!Existe(procedimiento.ProcedimientoId))
                return Insertar(procedimiento);
            else
                return Modificar(procedimiento);
        }

        private bool Insertar(Procedimiento procedimiento)
        {
            bool paso = false;

            try
            {
                if (_contexto.Procedimiento.Add(procedimiento) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Procedimiento procedimiento)
        {
            bool paso = false;

            try
            {
                /* 
                _contexto.Database.ExecuteSqlRaw($"DELETE FROM Detalle WHERE FacturaId={factura.PacienteId}");

                foreach (var Anterior in factura.Detalle)
                {
                    _contexto.Entry(Anterior).State = EntityState.Added;
                } 
                */

                _contexto.Entry(procedimiento).State = EntityState.Modified;
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
                var procedimiento = _contexto.Procedimiento.Find(Id);

                if (procedimiento != null)
                {
                    _contexto.Procedimiento.Remove(procedimiento);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public Procedimiento Buscar(int Id)
        {
            Procedimiento? procedimiento;

            try
            {
                procedimiento = _contexto.Procedimiento
                    .Where(p => p.ProcedimientoId == Id)
                    .AsNoTracking()
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return procedimiento;
        }

        public bool Existe(int Id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Procedimiento.Any(p => p.ProcedimientoId == Id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        
        public List<Procedimiento> GetList(Expression<Func<Procedimiento, bool>> critero)
        {
            List<Procedimiento> lista = new List<Procedimiento>();

            try
            {
                lista = _contexto.Procedimiento
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