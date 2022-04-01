using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.DAL;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.BLL
{
    public class AseguradoraBLL
    {
        private Contexto _contexto;

        public AseguradoraBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        
        public Aseguradora Buscar(int Id)
        {
            Aseguradora? aseguradora;

            try
            {
                aseguradora = _contexto.Aseguradora
                    .Where(p => p.AseguradoraId == Id)
                    .AsNoTracking()
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return aseguradora;
        }

        public List<Aseguradora> GetList(Expression<Func<Aseguradora, bool>> critero)
        {
            List<Aseguradora> lista = new List<Aseguradora>();

            try
            {
                lista = _contexto.Aseguradora
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