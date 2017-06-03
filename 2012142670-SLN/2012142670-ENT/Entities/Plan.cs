using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        public int plan { get; set; }
        public int codTipoPlan { get; set; }
        public TipoPlan TipoPlan { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public Plan()
        {
        }
    }
}
