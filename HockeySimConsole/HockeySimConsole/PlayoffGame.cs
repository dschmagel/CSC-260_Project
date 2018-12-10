using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class PlayoffGame : Game
    {
        // Class Constructor
        public PlayoffGame(string team1, string team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = 0;
            this.Team2Score = 0;
            this.Winner = 0;
            this.BoxScore = "";
        }

        // Method that simulates games
        public override void simGame()
        {
            int period = 1;

            while (period <= 3)
            {
                simPeriod();

                //Console.WriteLine("P" + period + ": Team 1 " + Team1Score + "  Team 2 " + Team2Score);

                period++;
            }

            // Teams are tied after regulation
            if (Team1Score == Team2Score)
                _playoffOvertime();

            // Winner in regulation
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

        // Overtime method
        private void _playoffOvertime()
        {
            // Random number is generated to see what happens next
            int ot = random.Next(0, 6);
            //Console.WriteLine(ot);

            // More Overtime!!!
            if (ot < 4)
            {
                _playoffOvertime();
            }

            // A winner is decided

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
