using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_JhonAlbert.DAL;
using ProyectoFinal_JhonAlbert.Entidades;

namespace ProyectoFinal_JhonAlbert.BLL
{
    public class PacienteBLL
    {
        private Contexto _contexto;

        public PacienteBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Guardar(Paciente paciente)
        {
            if (!Existe(paciente.PacienteId))
                return Insertar(paciente);
            else
                return Modificar(paciente);
        }

        private bool Insertar(Paciente paciente)
        {
            bool paso = false;

            try
            {
                _contexto.Paciente.Add(paciente).State = EntityState.Added;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        private bool Modificar(Paciente paciente)
        {
            bool paso = false;

            try
            {
                //_contexto.Database.ExecuteSqlRaw($"DELETE FROM Detalle WHERE PacienteId={paciente.PacienteId}");

                /* 
                foreach (var Anterior in paciente.)
                {
                    _contexto.Entry(Anterior).State = EntityState.Added;
                } 
                */

                _contexto.Entry(paciente).State = EntityState.Modified;

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
                var paciente = _contexto.Paciente.Find(Id);

                if (paciente != null)
                {
                    _contexto.Paciente.Remove(paciente);
                    paso = _contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public Paciente Buscar(int Id)
        {
            Paciente? paciente;

            try
            {
                paciente = _contexto.Paciente
                    .Where(p => p.PacienteId == Id)
                    .AsNoTracking()
                    .SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

            return paciente;
        }

        public bool Existe(int Id)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Paciente.Any(p => p.PacienteId == Id);
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        
        public List<Paciente> GetList(Expression<Func<Paciente, bool>> critero)
        {
            List<Paciente> lista = new List<Paciente>();

            try
            {
                lista = _contexto.Paciente
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