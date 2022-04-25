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

            //SearchMoviesByTitle("Lion");
        }

        /// <summary>
        /// Updates the UI with the game data.
        /// </summary>
        /// <param name="game"></param>
        private void UpdateUI(Movie movie)
        {
            //Update all the text fields
            TBLK_Title.Text = movie.Title;
            TBLK_Description.Text = movie.Plot;
            TBLK_Director.Text = movie.Director;
            TBLK_ReleaseDate.Text = movie.Year;
            TBLK_IMDBRating.Text = movie.imdbRating;
            TBLK_PEGI.Text = movie.Rated;

            //Update the image
            BitmapImage coverArt = new BitmapImage();
            coverArt.BeginInit();
            coverArt.UriSource = new Uri(movie.Poster);
            coverArt.EndInit();
            IMG_CoverArt.Stretch = Stretch.Fill;
            IMG_CoverArt.Source = coverArt;
        }

        /// <summary>
        /// Searches for movies with a given title or keyword
        /// </summary>
        /// <param name="title"></param>
        public void SearchMoviesByTitle(string title)
        {

            List<Movie> movies = new List<Movie>();
            
            if (RDBTN_API.IsChecked == true)
            { 
                //Get a single result set from the API
                movies.Add(APIManager.Instance.SearchMoviesByTitleOnly(title));
            }
            else
            {
                //Get a Result set from the database
                movies = DatabaseManager.Instance.SearchMovies(title);
            }

            LBX_Movies.ItemsSource = movies;
            
            UpdateUI(movies[0]);
        }

        /// <summary>
        /// Searches for a movie by a given title. 
        /// </summary>
        /// <param name="title"></param>
        public void SearchMovieByTitle(string title)
        {
            string baseUrl = "http://www.omdbapi.com/?apikey=";
            string APIKey = "5d4bd3b3";
            string titleSearchQuery = "&t=";
            string searchValue = title;
            string plotStatus = "&plot=full";

            APIManager manager = new APIManager();

            manager.endPoint = baseUrl + APIKey + titleSearchQuery + searchValue + plotStatus;

            string response = string.Empty;
            response = manager.MakeRequest();

            Movie movie = manager.ProcessDataRecord(response);
            UpdateUI(movie);
        }

        private void LBX_Movies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedMovie = (Movie) LBX_Movies.SelectedItem;
            if (selectedMovie != null)
            {
                SearchMovieByTitle(selectedMovie.Title);
            }
        }


        private void BTN_SearchMovie_Click(object sender, RoutedEventArgs e)
        {
            string value = TBX_Search.Text;
            if (value != null && value != "")
            {
                SearchMoviesByTitle(value);
            }
        }

        private void BTN_AddNew_Click(object sender, RoutedEventArgs e)
        {
            //Create a new instance of the addmovie window class
            AddMovie addMovieWindow = new AddMovie();
            //Display the add Move window
            addMovieWindow.Show();
        }

    }
}
