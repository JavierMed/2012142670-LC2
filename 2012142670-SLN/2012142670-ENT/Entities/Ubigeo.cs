using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Ubigeo
    {
        public int UbigeoId { get; set; }

        public int DistritoId { get; set; } 
        public Distrito Distrito { get; set; }        
        public ICollection<CentroAtencion> CentroAtencion { get; set; }

        public Ubigeo()
        {
            Distrito = new Distrito();
            CentroAtencion = new Collection<CentroAtencion>();
        }
    }
}
