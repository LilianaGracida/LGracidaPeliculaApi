﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Cine
    {
        public int IdCine { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal Venta { get; set; }
        public ML.Zona Zona { get; set; }
        public List<Object> Cines { get; set; } 
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public ML.Estadistica Estadistica { get; set; }
    }
}
