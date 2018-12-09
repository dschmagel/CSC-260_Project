using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class Season
    {
        List<string> Teams { get; set; }
        int NumGamesPer { get; set; }
        int NumPlayoffTeams { get; set; }
        public List<Standings> PlayoffTeams { get; set ; }

        public Season(List<string> teams, int games, int numPlayoffTeams)
        {
            this.Teams = teams;
            this.NumGamesPer = games;
            this.NumPlayoffTeams = numPlayoffTeams;
        }

        public List<Standings> simSeason()
        {
            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 27);

            string date = DateTime.Now.ToString("yyyy-MM-dd--HH-mm");
            string folder = dir + "HS_Season-" + date;
            System.IO.Directory.CreateDirectory(folder);

            List<RegGame> games = new List<RegGame>();

            string gamesPath = folder + "/" + "Games.txt";
            int _numTeams = Teams.Count;
            int count = 0;
            List<Standings> standings = new List<Standings>();

            for (int s = 0; s < _numTeams; s++)
            {
                standings.Add(new Standings(Teams[s]));
            }

            for (int i = 0; i < _numTeams; i++)
            {
                for (int j = 0; j < _numTeams; j++)
                {
                    if (i != j)
                    {
                        for (int k = 0; k < (NumGamesPer / 2); k++)
                        {

                            var currentGame = new RegGame(Teams[i], Teams[j]);

                            currentGame.simGame();

                            Standings currentTeam1Standing = standings.Single(s => s.TeamName == Teams[i]);
                            currentTeam1Standing.GamesPlayed++;

                            Standings currentTeam2Standing = standings.Single(s => s.TeamName == Teams[j]);
                            currentTeam2Standing.GamesPlayed++;

                            if (currentGame.Winner == 1)
                            {
                                currentTeam1Standing.Wins++;
                                currentTeam1Standing.GoalDiff += currentGame.Diff;
                                currentTeam1Standing.AwayWin++;

                                if (currentGame.Overtime == true)
                                {
                                    currentTeam1Standing.Row++;
                                }

                                if (currentGame.Shootout == true | currentGame.Overtime == true)
                                {
                                    currentTeam2Standing.OtShLosses++;
                                    currentTeam2Standing.HomeOtShLoss++;
                                }

                                else
                                {
                                    currentTeam2Standing.Losses++;
                                    currentTeam2Standing.HomeLoss++;
                                    currentTeam1Standing.Row++;
                                }

                                currentTeam2Standing.GoalDiff -= currentGame.Diff;

                            }

                            else
                            {
                                currentTeam2Standing.Wins++;
                                currentTeam2Standing.GoalDiff += currentGame.Diff;
                                currentTeam2Standing.HomeWin++;

                                if (currentGame.Overtime == true)
                                {
                                    currentTeam2Standing.Row++;
                                }

                                if (currentGame.Shootout == true | currentGame.Overtime == true)
                                {
                                    currentTeam1Standing.OtShLosses++;
                                    currentTeam1Standing.AwayOtShLoss++;
                                }

                                else
                                {
                                    currentTeam1Standing.Losses++;
                                    currentTeam1Standing.AwayLoss++;
                                    currentTeam2Standing.Row++;
                                }

                                currentTeam1Standing.GoalDiff -= currentGame.Diff;
                            }

                            games.Add(currentGame);

                            count++;
                            Console.WriteLine(currentGame.BoxScore);
                            System.IO.File.AppendAllText(gamesPath, currentGame.BoxScore + Environment.NewLine);
                        }


                    }
                }
            }


            Console.WriteLine(Environment.NewLine + "Total Games Played: " + count + Environment.NewLine);

            standings.Sort(delegate (Standings a, Standings b)
            {
                return b.GameWinPercentage.CompareTo(a.GameWinPercentage);
            });

            List<Standings> PlayoffTeams = standings.GetRange(0, NumPlayoffTeams);

            string standingsPath = folder + "/" + "Standings.txt";

            foreach (var s in standings)
            {
                string summary = (s.TeamName.PadRight(10) + "  GP: " + s.GamesPlayed + "  W: " + s.Wins + "  L: " + s.Losses + "  OT/SH: " + s.OtShLosses + "  P: " + s.Points + "  PCT: " + Math.Round(s.GameWinPercentage, 3)
                   + "  ROW: " + s.Row + "  +/-: " + s.GoalDiff + "  Home: " + s.HomeWin + "-" + s.HomeLoss + "-" + s.HomeOtShLoss + "  Away: " + s.AwayWin + "-" + s.AwayLoss + "-" + s.AwayOtShLoss);

                System.IO.File.AppendAllText(standingsPath, summary + Environment.NewLine);
                Console.WriteLine(summary);
            }

            return PlayoffTeams;
        }
        
    }
}
