﻿using _2012142670_ENT.Entities;
using _2012142670_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_PER.Repositories
{
    public class TrabajadorRepository : Repository<Trabajador>, ITrabajador
    {
        public TrabajadorRepository(_2012142670DBContext context) : base(context)
        {

        }
    }
}
