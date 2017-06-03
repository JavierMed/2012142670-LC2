using _2012142670_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.EntityTypeConfiguration
{
    public class EvaluacionConfiguration:EntityTypeConfiguration<Evaluacion>
    {
        public EvaluacionConfiguration()
        {
            HasKey(a => a.EvaluacionId);
            /*
            HasRequired(v => v.Venta)
                .WithMany(g => g.Evaluacion)
                .HasForeignKey(v => v.codVenta);

            
            //uno a muchos
            HasRequired(v => v.CentroAtencion)
                .WithMany(g => g.Evaluaciones)
                .HasForeignKey(v => v.codCentroAten);

           
            //muchos a uno
            HasMany(v => v.LineaTelefonicas)
                .WithRequired(g => g.Evaluacion)
                .HasForeignKey(c=>c.LineaTelefonicaId);
                */
            

        }
    }
}
