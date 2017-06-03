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
        public int precio { get; set; }
        public int ContratoId { get; set; }
        public int codLineaTele { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public Contrato Contrato { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public ICollection<Evaluacion> Evaluacion { get; set; }
        public ICollection<LineaTelefonica> LineaTelefonicas { get; set; }

        public Venta()
        {
            Cliente = new Collection<Cliente>();
            CentroAtencion = new CentroAtencion();
            Evaluacion = new Collection<Evaluacion>();
        }
    }
}
