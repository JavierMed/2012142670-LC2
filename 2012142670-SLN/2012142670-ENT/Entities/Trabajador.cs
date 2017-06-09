using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }
        public string NombreTrabajador { get; set; }

        public TipoTrabajador TipoTrabajador { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }

        public Trabajador()
        {
            TipoTrabajador = new TipoTrabajador();
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
