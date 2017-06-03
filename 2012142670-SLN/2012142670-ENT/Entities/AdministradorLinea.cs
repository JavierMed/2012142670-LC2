using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class AdministradorLinea
    {
        public int AdministradorLineaId { get; set; }

        public ICollection<LineaTelefonica> LineasTelefonicas { get; set; }

        public AdministradorLinea()
        {
            LineasTelefonicas = new Collection<LineaTelefonica>();
        }
    }
}
