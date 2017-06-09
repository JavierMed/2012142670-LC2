using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class EquipoCelular
    {
        public int EquipoCelularId { get; set; }
        public string Modelo { get; set; }

        public ICollection<AdministradorEquipo> AdministradorEquipos { get; set; }        
        public ICollection<Evaluacion> Evaluaciones { get; set; }

        public EquipoCelular()
        {
            AdministradorEquipos = new Collection<AdministradorEquipo>();
            Evaluaciones = new Collection<Evaluacion>();
        }
    }
}
