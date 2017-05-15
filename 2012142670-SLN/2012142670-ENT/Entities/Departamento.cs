using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Departamento
    {
        public int codDepartamento { get; set; }
        public string departamento { get; set; }
        public List<Provincia> Provincias { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public Departamento()
        {
            Provincias = new List<Provincia>();
            Ubigeo = new Ubigeo();
        }
    }
}
