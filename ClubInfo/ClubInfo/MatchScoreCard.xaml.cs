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
    /// Interaction logic for MatchScoreCard.xaml
    /// </summary>
    public partial class MatchScoreCard : Window
    {
        
        private ObservableCollection<Bowler> bowler;
        private ObservableCollection<Batsmen> batsmen;
        private Matches matches;

        public MatchScoreCard(MatchesObj selectedItem)
        {
            InitializeComponent();
            bowler = TestStorage.ReadXml<ObservableCollection<Bowler>>("Bowlers.xml");
            batsmen = TestStorage.ReadXml<ObservableCollection<Batsmen>>("Batsmen.xml");
            Grd_scorecard_batsman.ItemsSource = batsmen;
            Grd_scorecard_bowler.ItemsSource = bowler;
            Grd_scorecard_batsman_inn2.ItemsSource = batsmen;
            Grd_scorecard_bowler_inn2.ItemsSource = bowler;

        }

        public MatchScoreCard(MatchesObj selectedItem, Matches matches) : this(selectedItem)
        {
            this.matches = matches;
        }
    }
}
