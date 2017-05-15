using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class EquipoCelular
    {
        public int codEquiCelu { get; set; }
        public string modelo { get; set; }
        public int codAdminEqui { get; set; }
        public AdministradorEquipo AdminEquipo { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public EquipoCelular()
        {
            AdminEquipo = new AdministradorEquipo();
            Evaluacion = new Evaluacion();
        }
    }
}
