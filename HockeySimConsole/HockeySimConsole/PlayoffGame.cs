using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class PlayoffGame : Game
    {
        public PlayoffGame(string team1, string team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = 0;
            this.Team2Score = 0;
            this.Winner = 0;
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
                _playoffOvertime();

            else
            {
                if (Team1Score > Team2Score)
                {
                    Winner = 1;
                }


                else
                {
                    Winner = 2;
                }

                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  F");
                Console.WriteLine(BoxScore);
            }

            
            
        }

        private void _playoffOvertime()
        {
            int ot = random.Next(0, 6);
            //Console.WriteLine(ot);

            if (ot < 4)
            {
                _playoffOvertime();
            }

            else if (ot == 4)
            {
                Team1Score++;
                Winner = 1;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  OT");
                Console.WriteLine(BoxScore);
            }

            else
            {
                Team2Score++;
                Winner = 2;
                BoxScore = (Team1 + " " + Team1Score + "  " + Team2 + " " + Team2Score + "  OT");
                Console.WriteLine(BoxScore);
            }

            
        }
    }
}
