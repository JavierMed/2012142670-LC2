using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }  

        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }
        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Venta> Ventas { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public int CentroAtencionId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public int LineaTelefonicaId { get; set; }
        public LineaTelefonica LineaTelefonica { get; set; }
        public int EquipoCelularId { get; set; }
        public EquipoCelular EquipoCelular { get; set; }

        public Evaluacion()
        {
            Ventas = new Collection<Venta>();
        }
    }
}
