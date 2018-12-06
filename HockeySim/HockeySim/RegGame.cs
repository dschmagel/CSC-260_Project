using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySim
{
    class RegGame
    {
        string Team1 { get; set; }
        string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        bool Overtime { get; set; }
        bool Shootout { get; set; }
        string Winner { get; set; }

        public RegGame(string team1, string team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = 0;
            this.Team2Score = 0;
            this.Overtime = false;
            this.Shootout = false;
            this.Winner = "";
        }

        Random random = new Random();

        void simPeriod()
        {
            Team1Score = random.Next(0, 3) + Team1Score;
            Team2Score = random.Next(0, 3) + Team2Score;
        }

        void simGame()
        {
            int period = 1;

            while (period <= 3)
            {
                simPeriod();

                Console.WriteLine("P" + period + ": Team 1 " + Team1Score + "  Team 2 " + Team2Score);

                period++;
            }

            if (Team1Score == Team2Score)
            {
                int ot = random.Next(0, 4);
                Console.WriteLine(ot);

                if (ot < 2)
                {
                    Shootout = true;
                    int sh = random.Next(1, 7);
                    Console.WriteLine(sh);

                    if (sh < 3)
                    {
                        Team1Score++;
                        Winner = "Team 1";
                        Console.WriteLine("Team 1 " + Team1Score + "  Team 2 " + Team2Score + "  SH");
                    }

                    else
                    {
                        Team2Score++;
                        Winner = "Team 2";
                        Console.WriteLine("Team 1 " + Team1Score + "  Team 2 " + Team2Score + "  SH");
                    }
                }

                else if (ot == 2)
                {
                    Team1Score++;
                    Winner = "Team 1";
                    Overtime = true;
                    Console.WriteLine("Team 1 " + Team1Score + "  Team 2 " + Team2Score + "  OT");
                }

                else
                {
                    Team2Score++;
                    Winner = "Team 2";
                    Overtime = true;
                    Console.WriteLine("Team 1 " + Team1Score + "  Team 2 " + Team2Score + "  OT");
                }
            }

            else
            {
                if (Team1Score > Team2Score)
                    Winner = "Team 1";
                else
                    Winner = "Team 2";

                Console.WriteLine("Team 1 " + Team1Score + "  Team 2 " + Team2Score + "  F");
            }

        }

    }
}
