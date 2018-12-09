using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    public abstract class Game
    {
        protected string Team1 { get; set; }
        protected string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public int Winner { get; set; }
        public string BoxScore { get; set; }

        protected Random random = new Random();

        public abstract void simGame();

        public void simPeriod()
        {
            Team1Score = random.Next(0, 3) + Team1Score;
            Team2Score = random.Next(0, 3) + Team2Score;

            System.Threading.Thread.Sleep(10);
        }
    }
}
