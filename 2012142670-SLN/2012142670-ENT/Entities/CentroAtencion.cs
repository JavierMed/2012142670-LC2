using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }
        public string nomCentroAtencion { get; set; }
        public string direccion { get; set; }

        public int UbigeoId { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Evaluacion> Evaluaciones { get; set; }

        public CentroAtencion()
        {
            Ventas = new Collection<Venta>();
            Evaluaciones = new Collection<Evaluacion>();
        }
    }
}
