using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class EstadoEvaluacion
    {
        public int codEvaluacion { get; set; }
        public string evalua { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public EstadoEvaluacion()
        {
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
