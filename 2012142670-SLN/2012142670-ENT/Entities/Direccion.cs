using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Direccion
    {
        public int codDir { get; set; }
        public string direccion { get; set; }
        public int codUbigeo { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public CentroAtencion CentroAten { get; set; }

        public Direccion()
        {
            Ubigeo = new Ubigeo();
            CentroAten = new CentroAtencion();
        }
    }
}
