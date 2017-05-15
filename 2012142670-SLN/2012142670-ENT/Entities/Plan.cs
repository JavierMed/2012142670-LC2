using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Plan
    {
        public int codPlan { get; set; }
        public int plan { get; set; }
        public int codTipoPlan { get; set; }
        public TipoPlan TipoPlan { get; set; }

        public Plan()
        {
            TipoPlan = new TipoPlan();
        }
    }
}
