using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EstadisticaController : Controller
    {
        // GET: Estadistica
        public ActionResult Estadistica()
        {
            ML.Estadistica estadistica = new ML.Estadistica();
            ML.Cine cine = new ML.Cine();
            ML.Result resultVentas = BL.Cine.GetAll();
            cine.Cines= resultVentas.Objects;
            cine.Zona = new  ML.Zona();

            foreach (ML.Cine cine1 in cine.Cines)
            {
                if (cine1.Zona.IdZona ==1)
                {
                    estadistica.Zona1 = estadistica.Zona1 + cine1.Venta;
                }
                else if(cine1.Zona.IdZona==2)
                {
                    estadistica.Zona2=estadistica.Zona2 + cine1.Venta;
                }
               else if (cine1.Zona.IdZona == 3)
                {
                    estadistica.Zona3 = estadistica.Zona3+cine1.Venta;
                }
               else if (cine1.Zona.IdZona == 4)
                {
                    estadistica.Zona4 = estadistica.Zona4 + cine1.Venta;
                }
            }
            estadistica.TotalVentas = estadistica.Zona1+estadistica.Zona2+estadistica.Zona3+estadistica.Zona4;
            estadistica.Promedio1 = (estadistica.Zona1 * 100) / estadistica.TotalVentas;
            estadistica.Promedio2 = (estadistica.Zona2 * 100) / estadistica.TotalVentas;
            estadistica.Promedio3 = (estadistica.Zona3 * 100) / estadistica.TotalVentas;
            estadistica.Promedio4 = (estadistica.Zona4 * 100) / estadistica.TotalVentas;

                return View(estadistica);
        }
    }
}