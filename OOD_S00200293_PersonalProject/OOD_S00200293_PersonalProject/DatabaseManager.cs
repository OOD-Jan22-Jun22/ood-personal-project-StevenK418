using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
        ///  Searches DB for movies with a given title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Returns a list of movies matching the title</returns>
        public List<Movie> SearchMoviesByTitle(string title)
        {
            //Query the database for the given title and return the results
            var query = from m in db.Movies
                where m.Title.Equals(title)
                select m;

            //Convert the results to a list and return
            return query.ToList();
        }

        /// <summary>
        ///  Searches DB for movies with a given keyword.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Returns a list of movies matching the title</returns>
        public List<Movie> SearchMoviesByKeyword(string keyword)
        {
            //Query the database for the given title and return the results
            var query = from m in db.Movies
                where m.Title.Contains(keyword)
                select m;

            //Convert the results to a list and return
            return query.ToList();
        }

        /// <summary>
        /// Searches the db for movies of a given year. 
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Returns a list of all movies matching the result.</returns>
        public List<Movie> SearchMoviesByYear(string year)
        {
            //Query the database for the given year and return the results
            var query = from m in db.Movies
                where m.Year.Equals(year)
                select m;

            //Convert the results to a list and return
            return query.ToList();
        }

        /// <summary>
        /// Searches the db for movies of a given Director. 
        /// </summary>
        /// <param name="director"></param>
        /// <returns>Returns a list of all movies matching the result.</returns>
        public List<Movie> SearchMoviesByDirector(string director)
        {
            //Query the database for the given year and return the results
            var query = from m in db.Movies
                where m.Director.Equals(director)
                select m;

            //Convert the results to a list and return
            return query.ToList();
        }
    }
}
