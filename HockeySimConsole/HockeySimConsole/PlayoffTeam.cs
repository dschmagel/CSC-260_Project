using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class PlayoffTeam
    {
        // Class fields
        public string TeamName { get; set; }
        public int Seed { get; set; }

        // Class Constructor
        public PlayoffTeam( string teamName, int seed)
        {
            this.TeamName = teamName;
            this.Seed = seed;
        }

    }

}
