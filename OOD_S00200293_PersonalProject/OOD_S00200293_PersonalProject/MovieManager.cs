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
            //Construct a new movie object
            Movie movie = new Movie()
            {
                //Added a guid as an id to ensure unique value
                MovieID = Guid.NewGuid().ToString().Substring(0,8),
                Title = title,
                Year = year,
                imdbRating = imdbRating,
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
