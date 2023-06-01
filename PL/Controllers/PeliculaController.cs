using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace PL.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result resultProducto = new ML.Result();
            resultProducto.Objects = new List<Object>();
            ML.Pelicula pelicula = new ML.Pelicula();
            string api_key = "2e159baa88fac194ecd1c485f7e2fd00";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.GetAsync("movie/popular?api_key=" + api_key);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ML.Pelicula>();
                    readTask.Wait();


                    foreach (var resultItem in readTask.Result.results)
                    {
                        ML.Pelicula resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Pelicula>(resultItem.ToString());
                        resultProducto.Objects.Add(resultItemList);
                    }

                }
            }

            pelicula.results = resultProducto.Objects;//Mandar a llamar a la vista, mostrar la vista(HTML)
           
            return View(pelicula);
        }

       
        public ActionResult AddFavorito(int IdPelicula)
        {
            ML.Favorito favorito = new ML.Favorito();
            favorito.media_id = IdPelicula;
            ML.Result resultProducto = new ML.Result();
            resultProducto.Objects = new List<Object>();
            string api_key = "2e159baa88fac194ecd1c485f7e2fd00";
            string account_id = "19727829";
            string session_id = "6a12e9f819dc030b86a071e4ad2bee7bacf54a57";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.PostAsJsonAsync<ML.Favorito>("account/"+account_id+"/favorite?session_id="+session_id+"&api_key="+api_key,favorito);

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                { 
                 
                }
            }
             return RedirectToAction("Favorito");
        }

        public ActionResult DeleteFavorito(int IdPelicula)
        {
            ML.Favorito favorito = new ML.Favorito();
            favorito.media_id = IdPelicula;
            favorito.favorite = false;
            ML.Result resultProducto = new ML.Result();
            resultProducto.Objects = new List<Object>();
            string api_key = "2e159baa88fac194ecd1c485f7e2fd00";
            string account_id = "19727829";
            string session_id = "6a12e9f819dc030b86a071e4ad2bee7bacf54a57";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.PostAsJsonAsync<ML.Favorito>("account/" + account_id + "/favorite?session_id=" + session_id + "&api_key=" + api_key, favorito);

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                }
            }
            return RedirectToAction("Favorito");
        }


        [HttpGet]
        public ActionResult Favorito()
        {
            ML.Result resultProducto = new ML.Result();
            resultProducto.Objects = new List<Object>();
            ML.Pelicula pelicula = new ML.Pelicula();
            string api_key = "2e159baa88fac194ecd1c485f7e2fd00";
            string account_id = "19727829";
            string session_id = "6a12e9f819dc030b86a071e4ad2bee7bacf54a57";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.GetAsync("account/"+ account_id + "/favorite/movies?session_id="+session_id+ "&api_key=" + api_key);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ML.Pelicula>();
                    readTask.Wait();


                    foreach (var resultItem in readTask.Result.results)
                    {
                        ML.Pelicula resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Pelicula>(resultItem.ToString());
                        resultProducto.Objects.Add(resultItemList);
                    }

                }
            }

            pelicula.results = resultProducto.Objects;//Mandar a llamar a la vista, mostrar la vista(HTML)
            return View(pelicula);
        }
    }
}