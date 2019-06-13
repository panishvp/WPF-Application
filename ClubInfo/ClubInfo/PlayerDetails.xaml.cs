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
    /// Interaction logic for PlayerDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        ObservableCollection<Player> players;
        String filter = "";

        public PlayerDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            players = TestStorage.ReadXml<ObservableCollection<Player>>("PlayersInfo.xml");
            var results = from s in players where s.isActive == true select s;
            ObservableCollection<Player> oc = new ObservableCollection<Player>(results);
            Lbx_players.ItemsSource = results;
            Lbx_players.SelectedIndex = 0;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Tbx_name_search_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            filter = Tbx_name_search_input.Text.ToLower();
            Console.WriteLine(filter);
            if (filter == "")
            {
                var value = !newPlayers.IsChecked;
                if (value == true)
                    players_Unchecked();
                else
                    players_Checked();
                Lbx_players.SelectedIndex=0;
            }
            else
            {
                var value = !newPlayers.IsChecked;
                if (value == true)
                    players_Unchecked();
                else
                    players_Checked();
                Console.WriteLine(value);                
                var results = from s in players where s.playerName.ToLower().Contains(filter) && s.isActive.Equals(value) select s;                
                ObservableCollection <Player> oc = new ObservableCollection<Player>(results);
                Lbx_players.ItemsSource = oc;
              
            }
        }

        private void players_Checked()
        {
            var value = !newPlayers.IsChecked;
            var resP = from s in players where s.isActive.Equals(value) select s;
            foreach (var item in resP)
            {
                Console.WriteLine(item);
            }
            Lbx_players.ItemsSource = resP;
            Lbx_players.SelectedIndex = 0;
        }

        private void players_Unchecked()
        {
            var value = !newPlayers.IsChecked;
            var resP = from s in players where s.isActive.Equals(value) select s;
            foreach (var item in resP)
            {
                Console.WriteLine(item);
            }
            Lbx_players.ItemsSource = resP;
            Lbx_players.SelectedIndex = 0;
        }

        private void NewPlayers_Checked(object sender, RoutedEventArgs e)
        {
            players_Checked();
        }

        private void NewPlayers_Unchecked(object sender, RoutedEventArgs e)
        {
            players_Unchecked();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
