using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInfo
{
    public class Coach
    {
        public int coachId { get; set; }
        public String coachName { get; set; }
        public String birthPlace { get; set; }
        public String battingStyle { get; set; }
        public String bowlingStyle { get; set; }
        public String cachDepartment { get; set; }
        public List<String> coachAchievements { get; set; }
        public String imagePath { get; set; }
        public String role { get; set; }
        public String profile { get; set; }

    }
}
