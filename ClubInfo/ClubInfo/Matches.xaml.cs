using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ClubInfo
{
    /// <summary>
    /// Interaction logic for Matches.xaml
    /// </summary>
    public partial class Matches : Window
    {
        private ObservableCollection<MatchesObj> matches;

        public Matches()
        {
            InitializeComponent();
            matches = TestStorage.ReadXml<ObservableCollection<MatchesObj>>("Matches.xml");
            Grd_matches.ItemsSource = matches;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void Grd_Match_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MatchScoreCard matchScoreCard = new MatchScoreCard((MatchesObj) Grd_matches.SelectedItem, this);
            matchScoreCard.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
