using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        public DateTime FechaContrato { get; set; }

        public ICollection<Venta> Venta { get; set; }

        public Contrato()
        {
            Venta = new Collection<Venta>();
        }
    }
}
