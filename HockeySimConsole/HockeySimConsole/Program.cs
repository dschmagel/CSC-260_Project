using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets the current directory of the application files
            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 27);

            // Gets the file path from the user
            Console.Write("Please enter to path to a text file with team names." + Environment.NewLine);
            Console.Write("Ex: " + dir + "Teams.txt" + Environment.NewLine);
            string teamFile = Console.ReadLine();

            // Sets the team list from the given file
            List<string> teamList = System.IO.File.ReadAllLines(teamFile).ToList();

            // Prints teams
            Console.WriteLine();
            teamList.ForEach(Console.WriteLine);
            Console.WriteLine();

            // Gets the number of team matchups from the user
            Console.Write(Environment.NewLine + Environment.NewLine + "Please enter the number of times each team will play:" + Environment.NewLine);
            Console.Write("Must be divisible by 2" + Environment.NewLine);
            int matchCount = Convert.ToInt16(Console.ReadLine());

            // Gets the bracket size from the user
            Console.Write(Environment.NewLine + Environment.NewLine + "Please enter the number of teams that will make the playoff:" + Environment.NewLine);
            Console.Write("Must be 4, 8, or 16" + Environment.NewLine);
            int bracketSize = Convert.ToInt16(Console.ReadLine());

            // Gets the elimination style from the user
            Console.Write(Environment.NewLine + Environment.NewLine + "Please enter the desired elimination style:" + Environment.NewLine);
            Console.Write("1: Single Elimination" + Environment.NewLine);
            Console.Write("2: 5 Game Series" + Environment.NewLine);
            Console.Write("3: 7 Game Series" + Environment.NewLine);
            int eliminationStyle = 0;
            int eliminationStyleChoice = Convert.ToInt16(Console.ReadLine());
            
            switch (eliminationStyleChoice)
            {
                case 1:
                    eliminationStyle = 1;
                    break;
                case 2:
                    eliminationStyle = 5;
                    break;
                case 3:
                    eliminationStyle = 7;
                    break;
                default:
                    Console.Write("Error: Must be 4, 8, or 16");
                    Environment.Exit(0);
                    break;
            }

            Console.Write("\nPress enter to simulate the regular season:" + Environment.NewLine);
            Console.ReadLine();

            // Creates a new season and sims the games for it
            // The simulation reterns the standings the playoff bound teams
            var CurrentSeason = new Season(teamList, matchCount, bracketSize);
            List<Standings> playoffTeams = CurrentSeason.simSeason();


            Console.Write("\nPress any key to continue... " + Environment.NewLine);
            Console.ReadLine();

            // Creates a new playoff and sims the games for it
            var CurrentPlayoffs = new Playoffs(playoffTeams, bracketSize, eliminationStyle);
            CurrentPlayoffs.simPlayoffs();



            Console.ReadLine();


        }
    }
}
