using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestEase;

namespace OOD_S00200293_PersonalProject
{ 
    public class MovieManager
    {
        List<Movie> movies = new List<Movie>();

        public MovieManager() { }


        //Singleton instantiation and setup
        private static MovieManager instance = null;

        public static MovieManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MovieManager();
                }

                return instance;
            }
        }

        /// <summary>
        /// Adds a new movie item to the database.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="imdbRating"></param>
        /// <param name="posterURL"></param>
        /// <param name="plot"></param>
        /// <param name="rated"></param>
        /// <param name="director"></param>
        public void AddMovieToDatabase(string title, string year, string imdbRating, string posterURL, string plot, string rated, string director)
        {
            //Get the current number of rows in the database
            int numberOfRows = DatabaseManager.db.Movies.Count();

            //Increment the number of rows by one to get the id of the new movie
            numberOfRows++;

            //Construct a new movie object
            Movie movie = new Movie()
            {
                MovieID = numberOfRows.ToString(),
                Title = title,
                Year = year,
                ImbdRating = imdbRating,
                Poster = posterURL,
                Plot = plot,
                Rated = rated,
                Director = director
            };

            //Add the movie to the movies collection
            movies.Add(movie);

            //Add the movies to the database
            DatabaseManager.AddToDatabase(movies);

            //Clear the movies list
            movies.Clear();
        }
    }
}
