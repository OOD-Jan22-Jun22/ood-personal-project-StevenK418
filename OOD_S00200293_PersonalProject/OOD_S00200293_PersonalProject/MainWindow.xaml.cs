/*
 * Name:   Steven Kelly
 * ID:     S00200293
 * 
 *
 *
 */


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
        public void SearchMovies(string value)
        {
            List<Movie> movies = new List<Movie>();

            //Check if input is a string or a number first
            int parseResult = 0;
            if (int.TryParse(value, out parseResult) == false)
            {
                if (RDBTN_API.IsChecked == true && CHKBX_TitleOnly.IsChecked == false)
                {
                    //Get a single result set from the API
                    movies = APIManager.Instance.SearchMovies(value);
                }
                else if (RDBTN_API.IsChecked == true && CHKBX_TitleOnly.IsChecked == true)
                {
                    //Get a single result from the api
                    movies.Add(APIManager.Instance.SearchMoviesByTitleOnly(value));
                }
                else if (RDBTN_Database.IsChecked == true && CHKBX_TitleOnly.IsChecked == false)
                {
                    //Get a Result set from the database
                    movies = DatabaseManager.Instance.SearchMoviesByKeyword(value);
                }
                else if (RDBTN_Database.IsChecked == true && CHKBX_TitleOnly.IsChecked == true)
                {
                    //Get a Result set from the database
                    movies = DatabaseManager.Instance.SearchMoviesByTitle(value);
                }
            }
            else
            {
                if (RDBTN_Database.IsChecked == true)
                {
                    //Search the db for the given year
                    movies = DatabaseManager.Instance.SearchMoviesByYear(value);
                }
            }

            //movies.Sort();

            //If using api, get each individual movie record using the title and store as list
            if (RDBTN_API.IsChecked == true)
            {
                List<Movie> tempMovies = new List<Movie>();
                foreach (Movie movie in movies)
                {
                    tempMovies.Add(APIManager.Instance.SearchMoviesByTitleOnly(movie.Title));
                }

                LBX_Movies.ItemsSource = tempMovies;
            }
            else
            {
                LBX_Movies.ItemsSource = movies;
            }

            //Ensure we have results before passing to UpdateUI
            if (movies.Count > 0)
            {
                //Set the selected item in the listbox to the first result returned
                LBX_Movies.SelectedItem = 0;
                
                //Update the UI fields with data about first movie returned
                UpdateUI((Movie)LBX_Movies.SelectedItem);
            }
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

        private void RDBTN_Database_Checked(object sender, RoutedEventArgs e)
        {
            BTN_Random.IsEnabled = false;
        }

        private void RDBTN_API_Checked(object sender, RoutedEventArgs e)
        {
            BTN_Random.IsEnabled = true;
        }
    }
}
