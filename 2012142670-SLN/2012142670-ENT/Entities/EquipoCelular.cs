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
        public string modelo { get; set; }
        public int AdministradorEquipoId { get; set; }
        public AdministradorEquipo AdministradorEquipo { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public EquipoCelular()
        {
            AdministradorEquipo = new AdministradorEquipo();
            Evaluacion = new Evaluacion();
        }
    }
}
