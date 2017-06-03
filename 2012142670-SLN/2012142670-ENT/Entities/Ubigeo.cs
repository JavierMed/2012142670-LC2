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

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        public Ubigeo()
        {
            Departamento = new Departamento();
        }
    }
}
