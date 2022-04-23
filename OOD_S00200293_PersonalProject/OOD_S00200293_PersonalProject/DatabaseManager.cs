using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf.Transitions;

namespace OOD_S00200293_PersonalProject
{
    class DatabaseManager
    {
        public static Movie.MovieData db = new Movie.MovieData();

        public static void CreateDatabase(List<Movie> movies)
        {
            AddToDatabase(movies);
        }

        public static void AddToDatabase(List<Movie> movies)
        {
            using (db)
            {

                //Create
                foreach (Movie movie in movies)
                {
                    //Add each movie to the database
                    db.Movies.Add(movie);
                }

                
                //Save the changes to the database
                db.SaveChanges();
            }
        }
    }
}
