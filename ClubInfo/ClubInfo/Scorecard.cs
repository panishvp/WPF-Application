using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInfo
{
    public class Scorecard
    {
        public int matchId { get; set; }
        public String matchName { get; set; }
        public Innings firstInnings { get; set; }
        public Innings secondInnings { get; set; }

    }
}
