using _2012142670_ENT.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.EntityTypeConfiguration
{
    public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfiguration()
        {
            ToTable("CentroAtencion");
            HasKey(c => c.codCenAten);
            Property(c => c.codDir).HasColumnType("int");
            Property(c => c.nomCentroAtencion).HasMaxLength(100);

        }
    }
}
