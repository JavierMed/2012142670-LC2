using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Cliente
    {
        public int codCliente { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public List<Venta> Ventas { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Cliente()
        {
            Ventas = new List<Venta>();
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
