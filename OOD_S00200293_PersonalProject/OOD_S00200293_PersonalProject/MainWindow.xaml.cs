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

            SearchMoviesByTitle("Lion");
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
            TBLK_Publisher.Text = movie.Director;
            TBLK_ReleaseDate.Text = movie.Year;
            TBLK_ESRB.Text = movie.Rated;
            TBLK_PEGI.Text = movie.imbdRating;

            //Update the image
            BitmapImage coverArt = new BitmapImage();
            coverArt.BeginInit();
            coverArt.UriSource = new Uri(movie.Poster);
            coverArt.EndInit();
            IMG_CoverArt.Stretch = Stretch.Fill;
            IMG_CoverArt.Source = coverArt;

            /*//Update all the text fields
            TBLK_Title.Text = game.Title;
            TBLK_Description.Text = game.Description;
            TBLK_Publisher.Text = game.Publisher;
            TBLK_ReleaseDate.Text = game.ReleaseDate.ToShortDateString();
            TBLK_ESRB.Text = game.ESRB.ToString();
            TBLK_PEGI.Text = game.PEGI.ToString();

            //Update the image
            BitmapImage coverArt = new BitmapImage();
            coverArt.BeginInit();
            coverArt.UriSource = new Uri(game.Image, UriKind.Relative);
            coverArt.EndInit();
            IMG_CoverArt.Stretch = Stretch.Fill;
            IMG_CoverArt.Source = coverArt;*/
        }

        /// <summary>
        /// Searches for movies with a given title or keyword
        /// </summary>
        /// <param name="title"></param>
        public void SearchMoviesByTitle(string title)
        {
            string baseUrl = "http://www.omdbapi.com/?apikey=";
            string APIKey = "5d4bd3b3";
            string searchQueryPrefix = "&s=";
            string searchValue = title;
            
            APIManager manager = new APIManager();

            manager.endPoint = baseUrl + APIKey + searchQueryPrefix + title;

            string response = string.Empty;
            response = manager.MakeRequest();

            List<Movie> movies = (List<Movie>)manager.ProcessDataRecords(response);

            LBX_Games.ItemsSource = movies;
            
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

        private void LBX_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Movie selectedGame = (Movie) LBX_Games.SelectedItem;
            if (selectedGame != null)
            {
                SearchMovieByTitle(selectedGame.Title);
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
    }
}
