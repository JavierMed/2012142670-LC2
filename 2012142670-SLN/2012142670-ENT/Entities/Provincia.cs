using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Provincia
    {
        public int codProvincia { get; set; }
        public string nomProvincia { get; set; }
        public List<Distrito> Distritos { get; set; }
        public Departamento Departamento { get; set; }
        public Ubigeo Ubigeo { get; set; }

        public Provincia()
        {
            Distritos = new List<Distrito>();
            Departamento = new Departamento();
            Ubigeo = new Ubigeo();
        }
    }
}
