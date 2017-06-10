using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class LineaTelefonica
    {
        public int LineaTelefonicaId { get; set; }
        public int NumeroLinea { get; set; }
        
        public TipoLinea TipoLinea { get; set; }
        public ICollection<Evaluacion> Evaluaciones { get; set; }        
        public ICollection<AdministradorLinea> AdministradorLineas { get; set; }

        public LineaTelefonica()
        {
            AdministradorLineas = new Collection<AdministradorLinea>();
            Evaluaciones = new Collection<Evaluacion>();
        }
    }
}
