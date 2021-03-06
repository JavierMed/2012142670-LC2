﻿using _2012142670_ENT.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.EntityTypeConfiguration
{
    public class DistritoConfiguration : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfiguration()
        {
            HasRequired(c => c.Provincia)
                .WithMany(c => c.Distritos)
                .HasForeignKey(c => c.ProvinciaId);
        }
    }
}
