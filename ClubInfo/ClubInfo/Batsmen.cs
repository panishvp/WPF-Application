using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInfo
{
    public class Batsmen
    {
        public int matchId { get; set; }
        public String batsmenName { get; set; }
        public String outInfo { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public double strikeRate { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
    }
}
