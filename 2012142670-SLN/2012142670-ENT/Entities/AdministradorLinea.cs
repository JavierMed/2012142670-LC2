using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class AdministradorLinea
    {
        public int codAdminLinea { get; set; }
        public int numeroLinea { get; set; }
        public List<LineaTelefonica> LineaTelefonos { get; set; }

        public AdministradorLinea()
        {
            LineaTelefonos = new List<LineaTelefonica>();
        }
    }
}
