using _2012142670_ENT.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.EntityTypeConfiguration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            HasRequired(e => e.Evaluacion)
                .WithMany(v => v.Ventas)
                .HasForeignKey(v => v.EvaluacionId);


            /*HasRequired(c => c.Cliente)
               .WithMany(v => v.Ventas)
               .HasForeignKey(v => v.ClienteId);*/

            /*HasRequired(c => c.CentroAtencion)
                .WithMany(c => c.Ventas)
                .HasForeignKey(c => c.CentroAtencionId);

            /*HasRequired(e => e.LineaTelefonica)
                .WithMany(v => v.Ventas)
                .HasForeignKey(v => v.LineaTelefonicaId);*/

        }
    }
}
