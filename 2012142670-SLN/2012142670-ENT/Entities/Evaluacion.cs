using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Evaluacion
    {
        public int codEvaluacion { get; set; }
        public int codVenta { get; set; }
        public int codTipoEva { get; set; }
        public int codPlan { get; set; }
        public int codCli { get; set; }
        public int codEstadoEva { get; set; }
        public int codLineaTele { get; set; }
        public int codCentroAten { get; set; }
        public int codEquiCelu { get; set; }
        public int codTrabajador { get; set; }
        public Trabajador Trabajador { get; set; }
        public EstadoEvaluacion EstaEva { get; set; }
        public TipoEvaluacion TipoEva { get; set; }
        public Cliente Cliente { get; set; }
        public Venta Venta { get; set; }
        public CentroAtencion CentroAten { get; set; }
        public List<LineaTelefonica> LineaTelefonicas { get; set; }
        public List<EquipoCelular> EquipoCelulares { get; set; }
        public List<Plan> Planes { get; set; }

        public Evaluacion()
        {
            Trabajador = new Trabajador();
            EstaEva = new EstadoEvaluacion();
            TipoEva = new TipoEvaluacion();
            Cliente = new Cliente();
            Venta = new Venta();
            CentroAten = new CentroAtencion();
            LineaTelefonicas = new List<LineaTelefonica>();
            EquipoCelulares = new List<EquipoCelular>();
            Planes = new List<Plan>();
        }
    }
}
