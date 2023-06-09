using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Estadistica
    {
        public string Nombre { get; set; }
        public decimal Promedio1 { get; set; }
        public decimal Promedio2 { get; set; }
        public decimal Promedio3 { get; set; }
        public decimal Promedio4 { get; set; }
        public decimal TotalVentas { get; set; }
        public decimal Zona1 { get; set; }
        public decimal Zona2 { get; set; }
        public decimal Zona3 { get; set; }
        public decimal Zona4 { get; set; }
        public List<Object> Cines { get; set; }
        public ML.Cine cine { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public List<Object> Direcciones { get; set; }
        public string Direccion = "Av. Bosque Esmeralda Ote. 1, Bosque Esmeralda, 52930 Cd López Mateos, Méx., Mexico";
    }
}
