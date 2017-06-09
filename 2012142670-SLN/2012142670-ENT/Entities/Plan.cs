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
        public string NombrePlan { get; set; }
        public TipoPlan TipoPlan { get; set; }
        
        public ICollection<Evaluacion> Evaluaciones { get; set; }

        public Plan()
        {
            Evaluaciones = new Collection<Evaluacion>();
        }
    }
}
