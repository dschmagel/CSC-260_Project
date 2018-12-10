using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class Season
    {
        // Class fields
        List<string> Teams { get; set; }
        int NumGamesPer { get; set; }
        int NumPlayoffTeams { get; set; }
        public List<Standings> PlayoffTeams { get; set ; }

        // Class Constructor
        public Season(List<string> teams, int games, int numPlayoffTeams)
        {
            this.Teams = teams;
            this.NumGamesPer = games;
            this.NumPlayoffTeams = numPlayoffTeams;
        }

        // Simulates a new season
        public List<Standings> simSeason()
        {
            // Log file setup
            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 27);

            string date = DateTime.Now.ToString("yyyy-MM-dd--HH-mm");
            string folder = dir + "HS_" + date + "-Season";
            System.IO.Directory.CreateDirectory(folder);

            // List of games in season
            List<RegGame> games = new List<RegGame>();

            string gamesPath = folder + "/" + "Games.txt";
            int _numTeams = Teams.Count;
            int count = 0;

            // Make a new list of standings
            List<Standings> standings = new List<Standings>();

            // Each team gets a standing
            for (int s = 0; s < _numTeams; s++)
            {
                standings.Add(new Standings(Teams[s]));
            }

            // These nested loops pair each team up twice(Each team gets a 'home' game and an 'away' game vs each opponent)
            // then simulates all the matchups between each team.
            for (int i = 0; i < _numTeams; i++)
            {
                for (int j = 0; j < _numTeams; j++)
                {
                    if (i != j)
                    {
                        for (int k = 0; k < (NumGamesPer / 2); k++)
                        {

                            var currentGame = new RegGame(Teams[i], Teams[j]);

                            // After each game, the standinsg of both teams are updated
                            currentGame.simGame();

                            Standings currentTeam1Standing = standings.Single(s => s.TeamName == Teams[i]);
                            currentTeam1Standing.GamesPlayed++;

                            Standings currentTeam2Standing = standings.Single(s => s.TeamName == Teams[j]);
                            currentTeam2Standing.GamesPlayed++;

                            // If Team 1 wins
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

                            // If Team2 wins
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

                            // Add the game to the list of games
                            games.Add(currentGame);
                            count++;

                            // Logs!!
                            Console.WriteLine(currentGame.BoxScore);
                            System.IO.File.AppendAllText(gamesPath, currentGame.BoxScore + Environment.NewLine);
                        }


                    }
                }
            }

            // More logs

            Console.WriteLine(Environment.NewLine + "Total Games Played: " + count + Environment.NewLine);

            // Standing sorting
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

            // Returms the standings of the teams that make the playoffs
            return PlayoffTeams;
        }
        
    }
}
