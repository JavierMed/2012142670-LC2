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
        public string Nombre { get; set; }
        public string DNI { get; set; }
        
        public ICollection<Evaluacion> Evaluaciones{ get; set; }

        public Cliente()
        {
            Evaluaciones = new Collection<Evaluacion>();
        }
    }
}
