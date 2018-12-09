using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class PlayoffTeam
    {
        public string TeamName { get; set; }
        public int Seed { get; set; }

        public PlayoffTeam( string teamName, int seed)
        {
            this.TeamName = teamName;
            this.Seed = seed;
        }

    }

}
