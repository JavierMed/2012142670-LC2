using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.IRepositories
{
    public interface IUnityOfWork:IDisposable
    {
        //cada una de las propiedades deben ser solo lectura
        ICentroAtencion CentroAtencion { get; set; }
        ICliente Cliente { get; set; }
        IContrato Contrato { get; set; }
        IDepartamento Departamento { get; set; }
        IDistrito Distrito { get; set; }
        IEquipoCelular EquipoCelular { get; set; }
        IEvaluacion Evaluacion { get; set; }
        ILineaTelefonica LineaTelefonica { get; set; }
        IPlan Plan { get; set; }
        IProvincia Provincia { get; set; }
        ITrabajador Trabajador { get; set; }
        IUbigeo Ubigeo { get; set; }
        IVenta Venta { get; set; }

        int SaveChange();

        void StateModified(object entity);

    }
}
