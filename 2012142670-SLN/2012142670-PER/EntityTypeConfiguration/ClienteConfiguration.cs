using _2012142670_ENT.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.EntityTypeConfiguration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Cliente");

            HasKey(c => c.ClienteId);

            Property(c => c.nombre).HasMaxLength(255);
            Property(c => c.dni).HasMaxLength(20);

        }
    }
}
