using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Ubigeo
    {
        public int codUbigeo { get; set; }
        public int codDistrito { get; set; }
        public int codProvincia { get; set; }
        public int codDepartamento { get; set; }

        public ICollection<Departamento> Departamento { get; set; }
        public ICollection<Distrito> Distrito { get; set; }
        public ICollection<Provincia> Provincia { get; set; }

        public Ubigeo()
        {
            Departamento = new HashSet<Departamento>();
            Distrito = new HashSet<Distrito>();
            Provincia = new HashSet<Provincia>();
        }
    }
}
