using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class CineController : Controller
    {
        // GET: Cine
        public ActionResult GetAll()
        {
            ML.Cine cine = new ML.Cine();
            ML.Result result = BL.Cine.GetAll();

            cine.Cines = result.Objects;
            return View(cine);
        }

        [HttpPost]
        public ActionResult Delete(int IdCine)
        {
            ML.Cine cine = new ML.Cine();
            cine.IdCine = IdCine;
            ML.Result result = BL.Cine.Delete(cine);
            if (result.Correct)
            {
                ViewBag.Message = "El cine ha sido eliminado";
                return View("Modal");
            }
            else
            {
                ViewBag.Message = "El cine no ha sido eliminado";
                return View("Modal");
            }
        }

        [HttpGet]
        public ActionResult Form(int? IdCine)
        {
            ML.Result resultZona = BL.Zona.GetAll();
            ML.Cine cine = new ML.Cine();

            ML.Result resultCine = BL.Cine.GetAll();
            cine.Zona = new ML.Zona();


            if (IdCine == null)
            {
                cine.Zona.Zonas = resultZona.Objects;
                return View(cine);
            }
            else
            {
                ML.Result result = new ML.Result();
                result = BL.Cine.GetById(IdCine.Value);

                if (result.Correct)
                {

                    cine = ((ML.Cine)result.Object);
                    cine.Zona.Zonas = resultZona.Objects;
                    return View(cine);
                }
            }
            return View(cine);
        }
        [HttpPost]
        public ActionResult Form(ML.Cine cine)
        {
            ML.Result result = new ML.Result();

            if (cine.IdCine == 0)
            {
                //add 
                result = BL.Cine.Add(cine);

                if (result.Correct)
                {
                    ViewBag.Message = "Se completo el registro satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al insertar el registro";
                }

                return View("Modal");
            }
            else
            {

                //update
                result = BL.Cine.Update(cine);

                if (result.Correct)
                {
                    ViewBag.Message = "Se actualizo la información satisfactoriamente";
                }
                else
                {
                    ViewBag.Message = "Ocurrio un error al actualizar el registro";
                }
                return View("Modal");
            }

        }
    }
}