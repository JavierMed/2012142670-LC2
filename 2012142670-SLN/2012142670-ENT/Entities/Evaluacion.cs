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
        public int codVenta { get; set; }
        public int codTipoEva { get; set; }
        public int codPlan { get; set; }
        public int codCli { get; set; }
        public int codEstadoEva { get; set; }
        public int codLineaTele { get; set; }
        public int codCentroAten { get; set; }
        public int codEquiCelu { get; set; }

        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }

        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }

        public ICollection<Cliente> Cliente { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public int CentroAtencionId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public ICollection<LineaTelefonica> LineaTelefonicas { get; set; }
        public ICollection<EquipoCelular> EquipoCelulares { get; set; }
        public ICollection<Plan> Planes { get; set; }

        public Evaluacion()
        {
            Cliente = new Collection<Cliente>();
            LineaTelefonicas = new Collection<LineaTelefonica>();
            EquipoCelulares = new Collection<EquipoCelular>();
            Planes = new Collection<Plan>();
        }
    }
}
