using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf.Transitions;

namespace OOD_S00200293_PersonalProject
{
    public class DatabaseManager
    {
        public static Movie.MovieData db = new Movie.MovieData();

        public DatabaseManager(){}


        //Singleton instantiation and setup
        private static DatabaseManager instance = null;

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }

                return instance;
            }
        }

        /// <summary>
        /// Adds a new List of movies to the database
        /// </summary>
        /// <param name="movies"></param>
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

        /// <summary>
        /// Searches for movies with a given title or keyword
        /// </summary>
        /// <param name="title"></param>
        public List<Movie> SearchMovies(string title)
        {
            return null;

        }
    }
}
