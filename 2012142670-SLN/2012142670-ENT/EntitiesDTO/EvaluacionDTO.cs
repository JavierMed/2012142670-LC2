using _2012142670_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.EntitiesDTO
{
    public class EvaluacionDTO
    {
        public int EvaluacionId { get; set; }
        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }
    }
}
