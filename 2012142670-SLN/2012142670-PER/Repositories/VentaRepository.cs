﻿using _2012142670_ENT.Entities;
using _2012142670_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.Repositories
{
    public class VentaRepository : Repository<Venta>, IVenta
    {
        public VentaRepository(_2012142670DBContext context) : base(context)
        {

        }
    }
}
