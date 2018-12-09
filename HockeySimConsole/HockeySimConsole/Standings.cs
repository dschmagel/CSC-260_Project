using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class Standings
    { 
        private int _wins;
        private int _otShLosses;

        public string TeamName { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get { return _wins; } set { _wins = value; Points += 2; } }
        public int Losses { get; set; } 
        public int OtShLosses { get { return _otShLosses; } set { _otShLosses = value; Points++; } }
        public int Points { get; private set; }
        public double GameWinPercentage { get { return (Wins + 0.5 * Losses) / GamesPlayed; } }
        public int Row { get; set; }
        public int GoalDiff { get; set; }
        public int HomeWin { get; set; }
        public int HomeLoss { get; set; }
        public int HomeOtShLoss { get; set; }
        public int AwayWin { get; set; }
        public int AwayLoss { get; set; }
        public int AwayOtShLoss { get; set; }
        

        public Standings(string teamName)
        {
            this.TeamName = teamName;
            this.GamesPlayed = 0;
            this.Wins = 0;
            this.Losses = 0;
            this.OtShLosses = 0;
            this.Points = 0;
            this.Row = 0;
            this.GoalDiff = 0;
            this.HomeWin = 0;
            this.HomeLoss = 0;
            this.HomeOtShLoss = 0;
            this.AwayWin = 0;
            this.AwayLoss = 0;
            this.AwayOtShLoss = 0;
        }
    }
}
