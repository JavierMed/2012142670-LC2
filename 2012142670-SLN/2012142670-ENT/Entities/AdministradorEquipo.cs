using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class AdministradorEquipo
    {
        public int codAdminEqui { get; set; }
        public string nombreEquipo { get; set; }
        public int cantidad { get; set; }
        public List<EquipoCelular> EquipoCelulares { get; set; }

        public AdministradorEquipo()
        {
            EquipoCelulares = new List<EquipoCelular>();
        }
    }
}
