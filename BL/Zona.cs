using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Zona
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities context = new DL.CineEntities())
                {
                    var zonas = context.ZonaGetAll().ToList();
                    result.Objects = new List<object>();
                    if (zonas != null)
                    {
                        foreach (var obj in zonas)
                        {
                            ML.Zona zona = new ML.Zona();
                            zona.IdZona = obj.IdZona;
                            zona.Nombre = obj.Nombre;

                            result.Objects.Add(zona);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar la consulta";

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
