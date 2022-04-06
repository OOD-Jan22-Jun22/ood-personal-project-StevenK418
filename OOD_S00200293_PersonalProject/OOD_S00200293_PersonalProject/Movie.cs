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
        public string ImbdID { get; set; }
        public string PosterImage { get; set; }

        public override string ToString()
        {
            return $"{Movieid} - {Movieid} - {Year} - {ImbdID} - {PosterImage}";
        }
    }
}
