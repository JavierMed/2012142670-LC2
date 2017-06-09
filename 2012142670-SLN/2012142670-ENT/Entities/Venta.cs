using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int Precio { get; set; }

        public TipoPago TipoPago { get; set; }
        public ICollection<Contrato> Contratos { get; set; }

        //public int ClienteId { get; set; }
        //public Cliente Cliente { get; set; }
        //public int CentroAtencionId { get; set; }
        //public CentroAtencion CentroAtencion { get; set; }
        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }
        //public int LineaTelefonicaId { get; set; }
        //public LineaTelefonica LineaTelefonica { get; set; }

        public Venta()
        {
            Contratos = new Collection<Contrato>();
        }
    }
}
