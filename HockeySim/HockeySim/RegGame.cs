using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySim
{
    public class RegGame : Game
    {
        public bool Overtime { get; set; }
        public bool Shootout { get; set; }
        public int Diff { get; set; }

        public RegGame(string team1, string team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = 0;
            this.Team2Score = 0;
            this.Overtime = false;
            this.Shootout = false;
            this.Winner = 0;
            this.Diff = 1;
            this.BoxScore = "";
        }

        public override void simGame()
        {
            int period = 1;

            while (period <= 3)
            {
                simPeriod();

                //Console.WriteLine("P" + period + ": Team 1 " + Team1Score + "  Team 2 " + Team2Score);

                period++;
            }

            if (Team1Score == Team2Score)
                _regOvertime();

            else
            {
                if (Team1Score > Team2Score)
                {
                    Winner = 1;
                    Diff = Team1Score - Team2Score;
                }


                else
                {
                    Winner = 2;
                    Diff = Team2Score - Team1Score;
                }

                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  F");
            }
        }

        private void _regOvertime()
        {

            int ot = random.Next(0, 4);
            //Console.WriteLine(ot);

            if (ot < 2)
            {
                _shootout();
            }

            else if (ot == 2)
            {
                Team1Score++;
                Winner = 1;
                Overtime = true;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  OT");

            }

            else
            {
                Team2Score++;
                Winner = 2;
                Overtime = true;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  OT");

            }
        }

        private void _shootout()
        {
            Shootout = true;
            int sh = random.Next(1, 7);
            //Console.WriteLine(sh);

            if (sh < 3)
            {
                Team1Score++;
                Winner = 1;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  SH");

            }

            else
            {
                Team2Score++;
                Winner = 2;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  SH");

            }
        }
    }
}
