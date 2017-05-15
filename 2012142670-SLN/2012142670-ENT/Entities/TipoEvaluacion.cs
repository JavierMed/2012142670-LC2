using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class TipoEvaluacion
    {
        public int codTipoEva { get; set; }
        public string tipoEvaluacion { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public TipoEvaluacion()
        {
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
