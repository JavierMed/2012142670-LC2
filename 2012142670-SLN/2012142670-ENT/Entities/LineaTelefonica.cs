using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class LineaTelefonica
    {
        public int LineaTelefonicaId { get; set; }
        public string Numero { get; set; }
        
        public TipoLinea TipoLinea { get; set; }
        public Venta Venta { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public int AdministradorLineaId { get; set; }
        public AdministradorLinea AdministradorLinea { get; set; }

        public LineaTelefonica()
        {
            AdministradorLinea = new AdministradorLinea();
            Venta = new Venta();
            Evaluacion = new Evaluacion();
        }
    }
}
