using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OOD_S00200293_PersonalProject
{
    public class Movie
    {
        public string MovieID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImbdRating { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public string Rated { get; set; }
        public string Director { get; set; }

        public override string ToString()
        {
            return string.Format($"{Title} - {Year}");
        }

        public class MovieData : DbContext
        {
            public MovieData() : base("MyMovieData")
            {
            }

            public DbSet<Movie> Movies { get; set; }
        }
    }
}
