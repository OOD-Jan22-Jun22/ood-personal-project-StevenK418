using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestEase;

namespace OOD_S00200293_PersonalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Updates the UI with the game data.
        /// </summary>
        /// <param name="game"></param>
        private void UpdateUI(Movie movie)
        {
            if (movie != null)
            {
                //Update all the text fields
                TBLK_Title.Text = movie.Title;
                TBLK_Description.Text = movie.Plot;
                TBLK_Director.Text = movie.Director;
                TBLK_ReleaseDate.Text = movie.Year;
                TBLK_IMDBRating.Text = movie.imdbRating;
                TBLK_PEGI.Text = movie.Rated;

                //Check if API returns a valid image URL before asigning to image
                if (movie.Poster != "N/A")
                {
                    //Update the image
                    BitmapImage coverArt = new BitmapImage();
                    coverArt.BeginInit();
                    coverArt.UriSource = new Uri(movie.Poster);
                    coverArt.EndInit();
                    IMG_CoverArt.Stretch = Stretch.Fill;
                    IMG_CoverArt.Source = coverArt;
                }
            }
        }

        /// <summary>
        /// Searches for movies with a given title or keyword
        /// </summary>
        /// <param name="title"></param>
        public void SearchMovies(string title)
        {
            List<Movie> movies = new List<Movie>();
            
            if (RDBTN_API.IsChecked == true && CHKBX_TitleOnly.IsChecked == false)
            { 
                //Get a single result set from the API
                movies = APIManager.Instance.SearchMovies(title);
            }
            else if (RDBTN_API.IsChecked == true && CHKBX_TitleOnly.IsChecked == true)
            {
                //Get a single result from the api
                movies.Add(APIManager.Instance.SearchMoviesByTitleOnly(title));
            }
            else if(RDBTN_Database.IsChecked == true && CHKBX_TitleOnly.IsChecked == false)
            {
                //Get a Result set from the database
                movies = DatabaseManager.Instance.SearchMoviesByKeyword(title);
            }
            else if (RDBTN_Database.IsChecked == true && CHKBX_TitleOnly.IsChecked == true)
            {
                //Get a Result set from the database
                movies = DatabaseManager.Instance.SearchMoviesByTitle(title);
            }

            //movies.Sort();

            LBX_Movies.ItemsSource = movies;
            
            //Update the UI fields with data about first movie returned
            UpdateUI(movies[0]);
        }

        private void LBX_Movies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedMovie = (Movie) LBX_Movies.SelectedItem;
           
            if (selectedMovie != null)
            {
               selectedMovie = APIManager.Instance.SearchMoviesByTitleOnly(selectedMovie.Title);
            }

            UpdateUI(selectedMovie);
        }

        private void BTN_SearchMovie_Click(object sender, RoutedEventArgs e)
        {
            //Get the value entered in the search box
            string value = TBX_Search.Text;

            //Ensure the value entered is not null or empty string
            if (value != null && value != "")
            {
                //Search for the value entered
                SearchMovies(value);
            }
        }

        private void BTN_AddNew_Click(object sender, RoutedEventArgs e)
        {
            //Create a new instance of the addmovie window class
            AddMovie addMovieWindow = new AddMovie();
            //Display the add Move window
            addMovieWindow.Show();
        }

        private void BTN_Random_Click(object sender, RoutedEventArgs e)
        {
            Movie movie = (Movie)LBX_Movies.SelectedItem;
            
            MovieManager.Instance.AddMovieToDatabase
            (
                movie.Title,
                movie.Year, 
                movie.imdbRating, 
                movie.Poster,
                movie.Plot, 
                movie.Rated, 
                movie.Director
            );
        }
    }
}
