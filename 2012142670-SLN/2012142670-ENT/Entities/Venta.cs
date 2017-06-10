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
        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public Venta()
        {
            Contratos = new Collection<Contrato>();
        }
    }
}
