﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Contrato
    {
        public int codContrato { get; set; }
        public string contrato { get; set; }
        public Venta Venta { get; set; }

        public Contrato()
        {
            Venta = new Venta();
        }
    }
}
