using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class CentroAtencion
    {
        public int codCenAten { get; set; }
        public string nomCentroAtencion { get; set; }
        public int codDir { get; set; }
        public Direccion Direccion { get; set; }
        public List<Venta> Ventas { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public CentroAtencion()
        {
            Direccion = new Direccion();
            Ventas = new List<Venta>();
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
