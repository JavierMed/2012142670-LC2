using _2012142670_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.EntitiesDTO
{
    public class PlanDTO
    {
        public int PlanId { get; set; }
        public string NombrePlan { get; set; }
        public TipoPlan TipoPlan { get; set; }
    }
}
