using ProyectoFinal_JhonAlbert.DAL;
using ProyectoFinal_JhonAlbert.BLL;

namespace ProyectoFinal_JhonAlbert.Entidades
{
    public class UnitOfWork
    {
        private FacturaBLL _factura;
        private PacienteBLL _paciente;
        private ProcedimientoBLL _procedimiento;
        private Contexto _contexto;

        public UnitOfWork(Contexto contexto)
        {
            _contexto = contexto;
        }

        public FacturaBLL FacturaBLL
        {
            get
            {
                if (_factura == null)
                {
                    _factura = new FacturaBLL(_contexto);
                }

                return _factura;
            }
        }

        public PacienteBLL PacienteBLL
        {
            get
            {
                if (_paciente == null)
                {
                    _paciente = new PacienteBLL(_contexto);
                }

                return _paciente;
            }
        }

        public ProcedimientoBLL ProcedimientoBLL
        {
            get{

                if (_procedimiento == null)
                {
                    _procedimiento = new ProcedimientoBLL(_contexto);
                }

                return _procedimiento;
            }
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }

    }
}