using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public int EvaluacionId { get; set; }
        public Evaluacion Evaluacions { get; set; }

        public Cliente()
        {
        }
    }
}
