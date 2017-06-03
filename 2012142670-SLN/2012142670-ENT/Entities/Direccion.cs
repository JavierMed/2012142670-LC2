using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string nombredireccion { get; set; }
        public int UbigeoId { get; set; }
        public ICollection<Ubigeo> Ubigeo { get; set; }
        public int CentroAtencionId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }

        public Direccion()
        {
            Ubigeo = new Collection<Ubigeo>();
        }
    }
}
