using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OOD_S00200293_PersonalProject
{
    /// <summary>
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        List<Movie> movies = new List<Movie>();

        public AddMovie():base()
        {
            InitializeComponent();
        }

        private void BTN_AddMovie_Click(object sender, RoutedEventArgs e)
        {
            //Add the movie details to the database
            AddMovieToDatabase(TBX_TitleInput.Text, TBX_YearInput.Text, TBX_IMDBRatingInput.Text, TBX_PosterInput.Text, TBX_PlotInput.Text, TBX_RatedInput.Text, TBX_DirectorInput.Text);
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
        private void AddMovieToDatabase(string title, string year, string imdbRating, string posterURL, string plot, string rated, string director)
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

        /// <summary>
        /// Clears the placeholder text from a given textbox
        /// object.
        /// </summary>
        /// <param name="box"></param>
        private void ClearInputText(TextBox box)
        {
            //Clear the placeholder text from the textbox
            box.Clear();
        }
    }
}
