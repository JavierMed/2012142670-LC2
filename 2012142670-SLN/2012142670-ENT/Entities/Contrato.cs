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

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public Contrato()
        {
        }
    }
}
