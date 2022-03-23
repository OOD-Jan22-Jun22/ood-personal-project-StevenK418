using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_S00200293_PersonalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Game> games = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                games.Add(new Game("Call Of Duty", "A war game shooty bang bang!", new DateTime(), "Activision", 15, 18 ));
            }
            LBX_Games.ItemsSource = games;
        }


        private void UpdateUI(Game game)
        {
            TBLK_Title.Text = game.Title;
            TBLK_Description.Text = game.Description;
            TBLK_Publisher.Text = game.Publisher;
            TBLK_ReleaseDate.Text = game.ReleaseDate.ToShortDateString();
            TBLK_ESRB.Text = game.ESRB.ToString();
            TBLK_PEGI.Text = game.PEGI.ToString();

            BitmapImage coverArt = new BitmapImage();
            coverArt.BeginInit();
            coverArt.UriSource = new Uri("/Resources/Images/CallofDutycover.jpg", UriKind.Relative);
            coverArt.EndInit();
            IMG_CoverArt.Stretch = Stretch.Fill;
            IMG_CoverArt.Source = coverArt;
        }

        private void LBX_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = (Game) LBX_Games.SelectedItem;
            UpdateUI(selectedGame);
        }
    }
}
