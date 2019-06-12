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
    /// Interaction logic for CoachDetails.xaml
    /// </summary>
    public partial class CoachDetails : Window
    {
        ObservableCollection<Coach> coach;

        public CoachDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            coach = TestStorage.ReadXml<ObservableCollection<Coach>>("CoachDetails.xml");
            var results = from s in coach select s;
            ObservableCollection<Coach> oc = new ObservableCollection<Coach>(results);
            Lbx_coach.ItemsSource = results;
            Lbx_coach.SelectedIndex = 0;
            //var achv = (from ac in coach where ac.coachId.Equals(1) select ac.coachAchievements).ToList();
             LoadAchievements();
            //Lbx_coach_Achievements.ItemsSource = achv;
        }

       private void LoadAchievements()
        {
            var coachAchievements = TestStorage.ReadXml<ObservableCollection<CoachAchievements>>("CoachAchievements.xml");
            Lbx_coach_Achievements.ItemsSource = coachAchievements;
            /**foreach (var item in coachAchievements)
            {               
                    var achv = new Label();
                    Console.WriteLine(item.AchievementName.ToString());
                    achv.Content = item.AchievementName.ToString();
                    achv.Height = 200;             
                           

            }**/
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
