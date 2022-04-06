using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_S00200293_PersonalProject
{
    class Movie
    {
        public string Movieid { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string imbdRating { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public string Rated { get; set; }
        public string Director { get; set; }

        public override string ToString()
        {
            return string.Format($"{Title} - {Year} - {ImdbID} - {Poster}");
        }
    }
}
