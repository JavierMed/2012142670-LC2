using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Venta
    {
        public int codVenta { get; set; }
        public int precio { get; set; }
        public int codContrato { get; set; }
        public int codTipoPago { get; set; }
        public int codCli { get; set; }
        public int codLineaTele { get; set; }
        public int codCentroAten { get; set; }
        public int codEvalua { get; set; }

        public Venta()
        {

        }
    }
}
