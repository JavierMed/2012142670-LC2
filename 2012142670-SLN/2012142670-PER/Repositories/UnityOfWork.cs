using _2012142670_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.Repositories
{
    public class UnityOfWork:IUnityOfWork
    {
        private readonly _2012142670DBContext _Context;
        //private static UnityOfWork _Instance;
        //private static readonly object _Lock = new object();

        public ICentroAtencion CentroAtencion { get; set; }
        public ICliente Cliente { get; set; }
        public IContrato Contrato { get; set; }
        public IDepartamento Departamento { get; set; }
        public IDistrito Distrito { get; set; }
        public IEquipoCelular EquipoCelular { get; set; }
        public IEvaluacion Evaluacion { get; set; }
        public ILineaTelefonica LineaTelefonica { get; set; }
        public IPlan Plan { get; set; }
        public IProvincia Provincia { get; set; }
        public ITrabajador Trabajador { get; set; }
        public IUbigeo Ubigeo { get; set; }
        public IVenta Venta { get; set; }

        public UnityOfWork()
        {

        }

        public UnityOfWork(_2012142670DBContext context)
        {
            //Se crea un unico contexto para la base de datos
            //para apuntar todos los repositorios a la misma base de datos.
            _Context =context;

            CentroAtencion = new CentroAtencionRepository(_Context);
            Cliente = new ClienteRepository(_Context);
            Contrato = new ContratoRepository(_Context);
            Departamento = new DepartamentoRepository(_Context);
            Distrito = new DistritoRepository(_Context);
            EquipoCelular = new EquipoCelularRepository(_Context);
            Evaluacion = new EvaluacionRepository(_Context);
            LineaTelefonica = new LineaTelefonicaRepository(_Context);
            Plan = new PlanRepository(_Context);
            Provincia = new ProvinciaRepository(_Context);
            Trabajador = new TrabajadorRepository(_Context);
            Ubigeo = new UbigeoRepository(_Context);
            Venta = new VentaRepository(_Context);

        }


        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChange()
        {
            return _Context.SaveChanges();
        }

        /*int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }*/

        public void StateModified(object entity)
        {
            //throw new NotImplementedException();
            _Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
