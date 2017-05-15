using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class TipoPlan
    {
        public int codTipoPlan { get; set; }
        public string nomTipoPlan { get; set; }
        public List<Plan> Planes { get; set; }

        public TipoPlan()
        {
            Planes = new List<Plan>();
        }
    }
}
