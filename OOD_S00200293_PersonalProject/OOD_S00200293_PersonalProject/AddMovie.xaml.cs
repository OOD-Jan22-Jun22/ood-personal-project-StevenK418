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
            int numberOfRows = DatabaseManager.db.Movies.Count();
            numberOfRows++;

            Movie movie = new Movie()
            {
                MovieID = numberOfRows.ToString(),
                Title = TBX_TitleInput.Text,
                Year = TBX_YearInput.Text,
                ImbdRating = TBX_IMDBRatingInput.Text,
                Poster = TBX_PosterInput.Text,
                Plot = TBX_PlotInput.Text,
                Rated = TBX_YearInput.Text,
                Director = TBX_DirectorInput.Text
            };

            movies.Add(movie);

            DatabaseManager.AddToDatabase(movies);

            //Clear the movies list
            //movies.Clear();
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
