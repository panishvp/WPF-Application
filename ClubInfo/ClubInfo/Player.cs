using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInfo
{
    public class Player
    {
        public int playerId { get; set; }
        public String playerName { get; set; }
        public String role { get; set; }
        public String birthPlace { get; set; }
        public String battingStyle { get; set; }
        public String bowlingStyle { get; set; }
        public int totalMatches { get; set; }
        public int totalRuns { get; set; }
        public int wickets { get; set; }
        public int highestRuns { get; set; }
        public float strikeRate { get; set; }
        public float bowlingEconomy { get; set; }
        public int hundreads { get; set; }
        public int fifties { get; set; }
        public bool isActive { get; set; }
        public String imagePath { get; set; }
        public String description { get; set; }
        public String debut { get; set; }
        public String lastMatch { get; set; }

}
}
