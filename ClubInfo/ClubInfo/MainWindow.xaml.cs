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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClubInfo
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

        private void Button_Open_Player_Details_Window(object sender, RoutedEventArgs e)
        {
            var playerWindow = new PlayerDetails()
            {
                Owner = this
            };
            playerWindow.Show();
        }

        private void Button_Open_Coach_Details_Window(object sender, RoutedEventArgs e)
        {
            var coachWindow = new CoachDetails()
            {
                Owner = this
            };
            coachWindow.Show();
        }       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //generateMatches(40); 
            //generateScoreCard(40);
            //generateBatnBowlers();
            GenerateCoachAchievements(5);
        }

        private void GeneratePlayers(int count)
        {
            Random rnd = new Random();
            var list = new ObservableCollection<Player>();
            Player play = new Player();
            for (int i = 0; i < count - 1; i++)
            {

                int PlayerId = rnd.Next(100);
                String PlayerName = " ";
                String Place = " ";
                String BattingStyle = " ";
                String BowlingStyle = " ";
                int TotalMatches = rnd.Next(10, 100);
                int TotalRuns = rnd.Next(10, 100);
                int Wickets = rnd.Next(10, 100);
                int HighestRuns = rnd.Next(10, 100);
                float StrikeRate = rnd.Next(10, 100);
                float BowlingEconomy = rnd.Next(10, 100);
                int Hundreads = rnd.Next(10, 100);
                int Fifties = rnd.Next(10, 100);

                play = new Player
                {
                    playerId = PlayerId,
                    playerName = PlayerName,
                    role = PlayerName,
                    birthPlace = Place,
                    battingStyle = BattingStyle,
                    bowlingStyle = BowlingStyle,
                    totalMatches = TotalMatches,
                    totalRuns = TotalRuns,
                    wickets = Wickets,
                    highestRuns = HighestRuns,
                    strikeRate = StrikeRate,
                    bowlingEconomy = BowlingEconomy,
                    hundreads = Hundreads,
                    fifties = Fifties,
                    isActive = true
                };
                list.Add(play);

            }

            TestStorage.WriteXml<ObservableCollection<Player>>(list, "Players.xml");
        }


        private void GenerateCoachAchievements(int num)
        {
            String coachAchiv = "His interview from Bangkok for the Head Coach and his subsequent tiff with Sourav Ganguly made headlines, but after Anil Kumble's unceremonious exit after the 2017 Champions Trophy, he was back in the chair.";
            var list = new ObservableCollection<CoachAchievements>();
            CoachAchievements coachAchievements = new CoachAchievements();
            for(int i=0; i< num; i++)
            {
                coachAchievements = new CoachAchievements
                {
                    AchievementId = i,
                    CoachId = 1,
                    AchievementName = coachAchiv

                };
                list.Add(coachAchievements);
            }
            TestStorage.WriteXml<ObservableCollection<CoachAchievements>>(list, "CoachAchievements.xml");


        }

        private void GenerateCoach(int count)
        {
            Random rnd = new Random();
            var list = new ObservableCollection<Coach>();
            Coach coach = new Coach();
            String coachAchiv = "His interview from Bangkok for the Head Coach and his subsequent tiff with Sourav Ganguly made headlines, but after Anil Kumble's unceremonious exit after the 2017 Champions Trophy, he was back in the chair.";
            List<String> coachachv = new List<string>();
            coachachv.Add(coachAchiv);
            coachachv.Add(coachAchiv);
            coachachv.Add(coachAchiv);
            coachachv.Add(coachAchiv);
            coachachv.Add(coachAchiv);
            for (int i=0; i< count; i++)
            {

                coach = new Coach
                {
                    coachId = rnd.Next(1, 9),
                    birthPlace = "Heidelberg",
                    coachName = "Ravi Shastri",
                    cachDepartment = "Head",
                    imagePath = "Images/3.png",
                    coachAchievements = coachachv,
                    battingStyle = "Right Handed Bat",
                    bowlingStyle = "Right Handed Bat",
                    role = "Batsmen"

            };
                list.Add(coach);
            }
            TestStorage.WriteXml<ObservableCollection<Coach>>(list, "CoachDetails.xml");
        }

        private void Matches_Button_Click(object sender, RoutedEventArgs e)
        {
            var coachWindow = new Matches()
            {
                Owner = this
            };
            coachWindow.Show();
        }

        private void generateMatches (int cnt)
        {
            var list = new ObservableCollection<MatchesObj>();
            MatchesObj matches = new MatchesObj();

          

            for (int i =0; i < cnt; i++)
            {
                matches = new MatchesObj
                {
                    matchId = i,
                    matchBetween = "TeamA VS Team B",
                    result = "Team A won by 20 Runs",                   
                    date = "12/09/2014",
                    matchType = "Home"
                    

                };
                list.Add(matches);
            }
            TestStorage.WriteXml<ObservableCollection<MatchesObj>>(list, "Matches.xml");
        }

        private void generateBatnBowlers()
        {
            Bowler bowler = new Bowler();
            Batsmen batsmen = new Batsmen();
            Innings firstInnings = new Innings();
            Innings secondInnings = new Innings();
            List<Bowler> bowlerList = new List<Bowler>();
            List<Batsmen> batsmens = new List<Batsmen>();
            var batList = new ObservableCollection<Batsmen>();
            var bowlList = new ObservableCollection<Bowler>();

            for (int i = 0; i < 5; i++)
            {
                bowler = new Bowler
                {
                    matchId = 1,
                    bowlerName = "Bumrah",
                    overs = 10,
                    runs = 60,
                    economy = 6

                };
                bowlList.Add(bowler);
            }

            for (int i = 0; i < 10; i++)
            {
                batsmen = new Batsmen
                {
                    matchId = 1,
                    batsmenName = "MS Doni",
                    balls = 14,
                    runs = 27,
                    fours = 3,
                    sixes = 1,
                    strikeRate = 197.65,
                    outInfo = "Caught by abcdefgh"
                };
                batList.Add(batsmen);
            }
            TestStorage.WriteXml<ObservableCollection<Batsmen>>(batList, "Batsmen.xml");
            TestStorage.WriteXml<ObservableCollection<Bowler>>(bowlList, "Bowlers.xml");


        }

            private void generateScoreCard(int cnt)
        {
            Scorecard scoreCard = new Scorecard();
            Bowler bowler = new Bowler();
            Batsmen batsmen = new Batsmen();
            Innings firstInnings = new Innings();
            Innings secondInnings = new Innings();
            List<Bowler> bowlerList = new List<Bowler>();
            List<Batsmen> batsmens = new List<Batsmen>();
            var scoreList = new ObservableCollection<Scorecard>();
            for (int i=0; i<10; i++)
            {
                batsmen = new Batsmen
                {
                    matchId = 1,
                    batsmenName = "MS Doni",
                    balls = 14,
                    runs = 27,
                    fours = 3,
                    sixes = 1,
                    strikeRate = 197.65,
                    outInfo = "Caught by abcdefgh"
                };

                batsmens.Add(batsmen);
            }

            for(int i=0; i<5; i++)
            {
                bowler = new Bowler
                {
                    matchId = 1,
                    bowlerName = "Bumrah",
                    overs = 10,
                    runs = 60,
                    economy = 6

                };
                bowlerList.Add(bowler);
            }
            firstInnings = new Innings
            {
                batsmenList = batsmens,
                bowlerList = bowlerList
            };
            secondInnings = new Innings
            {
                batsmenList = batsmens,
                bowlerList = bowlerList
            };

            for(int j =0; j< cnt; j++)
            {
                scoreCard = new Scorecard
                {
                    matchId = j,
                    matchName = "TeamA VS TeamB",
                    firstInnings = firstInnings,
                    secondInnings = secondInnings
                };
                scoreList.Add(scoreCard);

            }
            TestStorage.WriteXml<ObservableCollection<Scorecard>>(scoreList, "ScoreCard.xml");

        }        
    }
}
