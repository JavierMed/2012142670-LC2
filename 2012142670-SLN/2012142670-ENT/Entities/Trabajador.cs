﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012142670_ENT.Entities
{
    public class Trabajador
    {
        public int codTrabajador { get; set; }
        public string nomTrabajador { get; set; }
        public TipoTrabajador TipoTraba { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Trabajador()
        {
            TipoTraba = new TipoTrabajador();
            Evaluaciones = new List<Evaluacion>();
        }
    }
}
