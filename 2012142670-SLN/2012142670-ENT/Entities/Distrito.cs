using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public string nomDistrito { get; set; }

        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }

        public Distrito()
        {
            Provincia = new Provincia();
        }
    }
}
