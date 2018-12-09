using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class PlayoffRound
    {
        protected PlayoffTeam Team1 { get; set; }
        protected PlayoffTeam Team2 { get; set; }
        public int Team1Wins { get; set; }
        public int Team2Wins { get; set; }
        protected int NumOfGames { get; set; }
        public int SeriesWinner { get; set; }
        string _filePath;

        public PlayoffRound(PlayoffTeam team1, PlayoffTeam team2, int numOfGames, string filePath)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Wins = 0;
            this.Team2Wins = 0;
            this.NumOfGames = numOfGames;
            this._filePath = filePath;
        }

        public void simRound()
        {
            //Console.WriteLine("Enter Playoff Round");
            Console.WriteLine();
            System.IO.File.AppendAllText(_filePath, Environment.NewLine + Environment.NewLine);

            if (NumOfGames == 1)
            {
                var currentPlayoffGame = new PlayoffGame(Team1.TeamName, Team2.TeamName);
                currentPlayoffGame.simGame();
                System.IO.File.AppendAllText(_filePath, currentPlayoffGame.BoxScore + Environment.NewLine);

                if (currentPlayoffGame.Winner == 1)
                {
                    SeriesWinner = 1;
                    Team1Wins++;
                }

                else
                {
                    SeriesWinner = 2;
                    Team2Wins++;
                }
            }

            else if (NumOfGames == 5)
            {
                do
                {
                    var currentPlayoffGame = new PlayoffGame(Team1.TeamName, Team2.TeamName);
                    currentPlayoffGame.simGame();
                    System.IO.File.AppendAllText(_filePath, currentPlayoffGame.BoxScore + Environment.NewLine);

                    if (currentPlayoffGame.Winner == 1)
                        Team1Wins++;

                    else
                        Team2Wins++;

                    //Console.WriteLine("Teams 1: " + Team1Wins);
                    //Console.WriteLine("Teams 2: " + Team2Wins);
                }
                while (Team1Wins < 3 & Team2Wins < 3);

                if (Team1Wins > Team2Wins)
                {
                    SeriesWinner = 1;

                }

                else
                {
                    SeriesWinner = 2;
                }
            }

            else if (NumOfGames == 7)
            {
                do
                {
                    var currentPlayoffGame = new PlayoffGame(Team1.TeamName, Team2.TeamName);
                    currentPlayoffGame.simGame();
                    System.IO.File.AppendAllText(_filePath, currentPlayoffGame.BoxScore + Environment.NewLine);

                    if (currentPlayoffGame.Winner == 1)
                        Team1Wins++;

                    else
                        Team2Wins++;

                    //Console.WriteLine("Teams 1: " + Team1Wins);
                    //Console.WriteLine("Teams 2: " + Team2Wins);
                }
                while (Team1Wins < 4 & Team2Wins < 4);

                if (Team1Wins > Team2Wins)
                {
                    SeriesWinner = 1;

                }

                else
                {
                    SeriesWinner = 2;
                }
            }

            else
                Console.WriteLine("Error");

        }
    }
}
