using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class LineaTelefonica
    {
        public int codLineaTelefo { get; set; }
        public string nomLinea { get; set; }
        public int codAdminLinea { get; set; }
        public int codTipoLinea { get; set; }
        public AdministradorLinea AdminLinea { get; set; }
        public List<TipoLinea> TipoLineas { get; set; }
        public Venta Venta { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public LineaTelefonica()
        {
            AdminLinea = new AdministradorLinea();
            TipoLineas = new List<TipoLinea>();
            Venta = new Venta();
            Evaluacion = new Evaluacion();
        }
    }
}
