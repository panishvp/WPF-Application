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

            Cmbx_Year.SelectedIndex = 1;
            Cmbx_location.SelectedIndex = 1;
        }

        private void Grd_Match_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MatchScoreCard matchScoreCard = new MatchScoreCard((MatchesObj) Grd_matches.SelectedItem, this);
            matchScoreCard.Show();
        }

        private void Cmbx_location_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItems = (ComboBoxItem)(Cmbx_location.SelectedValue);
            string value = (string)(selectedItems.Content);         
            Console.WriteLine(value);

            switch (value)
            {
                case "Away":
                    Grd_matches.ItemsSource = (from match in matches where match.matchType.Contains("Away") select match).ToList();
                    break;

                case "Home":
                    Grd_matches.ItemsSource = (from match in matches where match.matchType.Contains("Home") select match).ToList();
                    break;

                case "All":
                    Grd_matches.ItemsSource = (from match in matches select match).ToList();
                    break;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

     

        private void Cmbx_Year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedYearItems = (ComboBoxItem)(Cmbx_Year.SelectedValue);
            string yearValue = (string)(selectedYearItems.Content);
            Console.WriteLine(yearValue);
            Grd_matches.ItemsSource = (from match in matches where match.date.Contains(yearValue) select match).ToList();
        }
    }
}
