using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cine
    {
        public static ML.Result Add(ML.Cine cine)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities1 context = new DL.CineEntities1())
                {
                    var query = context.CineAdd(cine.Nombre, cine.Direccion, cine.Venta, cine.Zona.IdZona,cine.Latitud,cine.Longitud);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar el insert";
                    }
                    result.Correct = true;
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result Update(ML.Cine cine)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities1 context = new DL.CineEntities1())
                {
                    var query = context.CineUpdate(cine.IdCine, cine.Nombre, cine.Direccion, cine.Venta, cine.Zona.IdZona,cine.Longitud,cine.Latitud);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar el update";
                    }
                    result.Correct = true;
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result Delete(ML.Cine cine)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities1 context = new DL.CineEntities1())
                {
                    var query = context.CineDelete(cine.IdCine);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se ha podido realizar el insert";
                    }
                    result.Correct = true;
                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result GetById(int IdCine)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities1 context = new DL.CineEntities1())
                {
                    var obj = context.CineGetById(IdCine).FirstOrDefault();
                    result.Objects = new List<object>();

                    if (obj != null)
                    {
                        ML.Cine cine = new ML.Cine();
                        cine.IdCine = obj.IdCine;
                        cine.Nombre = obj.Cine;
                        cine.Direccion = obj.Direccion;
                        cine.Venta = obj.Venta.Value;
                        cine.Latitud = obj.Latitud.Value;
                        cine.Longitud = obj.Longitud.Value;

                        cine.Zona = new ML.Zona();
                        cine.Zona.IdZona = obj.IdZona;
                        cine.Zona.Nombre = obj.Zona;

                        result.Object = cine;
                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo realizar la consulta";
                    }

                }
            }

            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.CineEntities1 context = new DL.CineEntities1())
                {
                    var cines = context.CineGetAll().ToList();
                    result.Objects = new List<object>();
                    if (cines != null)
                    {
                        foreach (var obj in cines)
                        {
                            ML.Cine cine = new ML.Cine();
                            cine.IdCine = obj.IdCine;
                            cine.Nombre = obj.Cine;
                            cine.Direccion = obj.Direccion;
                            cine.Venta = obj.Venta.Value;
                            cine.Latitud = obj.Latitud.Value;
                            cine.Longitud = obj.Longitud.Value;

                            cine.Zona = new ML.Zona();
                            cine.Zona.IdZona = obj.IdZona;
                            cine.Zona.Nombre = obj.Zona;

                            result.Objects.Add(cine);

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
