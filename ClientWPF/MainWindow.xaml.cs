using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using BLL;
using Core;

namespace ClientWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MovieController mCtr = new MovieController();

            String movString = null;

            List<Movie> mList = mCtr.GetMovies(datePicker.DisplayDate);

            if (mList.Count == 0)
            {
                txtBox.Text = "Fandt intet";
            }
            else
            {


                foreach (Movie mov in mList)
                {
                    movString += mov.Name + "\n";

                    foreach (Show show in mov.Shows)
                    {
                        movString += " - " + show.DateTime.ToString() + "\n";
                    }

                }

                txtBox.Text = movString;
            }
        }
    }
}
