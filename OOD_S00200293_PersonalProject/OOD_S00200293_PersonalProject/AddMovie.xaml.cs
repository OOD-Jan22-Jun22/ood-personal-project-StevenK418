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
       

        public AddMovie():base()
        {
            InitializeComponent();
        }

        private void BTN_AddMovie_Click(object sender, RoutedEventArgs e)
        {
            //Add the movie details to the database
            MovieManager.Instance.AddMovieToDatabase
                                    (
                                        TBX_TitleInput.Text, 
                                        TBX_YearInput.Text, 
                                        TBX_IMDBRatingInput.Text, 
                                        TBX_PosterInput.Text, 
                                        TBX_PlotInput.Text, 
                                        TBX_RatedInput.Text, 
                                        TBX_DirectorInput.Text
                                    );
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

        private void TBX_TitleInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_YearInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_DirectorInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_PlotInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_IMDBRatingInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_RatedInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }

        private void TBX_PosterInput_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearInputText((TextBox)sender);
        }
    }
}
