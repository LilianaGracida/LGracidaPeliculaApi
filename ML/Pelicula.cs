using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Pelicula
    {
        public string path = " https://www.themoviedb.org/t/p/w300_and_h450_bestv2";
        public dynamic page { get; set; }
        public dynamic adult { get; set; }
        public dynamic backdrop_path { get; set; }
        public dynamic genre_ids { get; set; }
        public int id { get; set; }
        public dynamic original_language { get; set; }
        public dynamic original_title { get; set; }
        public dynamic overview { get; set; }
        public dynamic popularity { get; set; }
        public dynamic poster_path { get; set; }
        public dynamic release_date { get; set; } 
        public dynamic title { get; set; } 
        public dynamic video { get; set; } 
        public dynamic vote_average { get; set; } 
        public dynamic vote_count { get; set; }

        public List<Object> results { get; set; }
        public List<Object> Peliculas { get; set; }
    }
}
