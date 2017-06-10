using _2012142670_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.EntitiesDTO
{
    public class TrabajadorDTO
    {
        public int TrabajadorId { get; set; }
        public string NombreTrabajador { get; set; }
        public TipoTrabajador TipoTrabajador { get; set; }
    }
}
