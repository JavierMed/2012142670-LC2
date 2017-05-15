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
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public Contrato Contrato { get; set; }
        public CentroAtencion CentroAten { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public Venta()
        {
            Cliente = new Cliente();
            TipoPago = new TipoPago();
            Contrato = new Contrato();
            CentroAten = new CentroAtencion();
            Evaluacion = new Evaluacion();
        }
    }
}
