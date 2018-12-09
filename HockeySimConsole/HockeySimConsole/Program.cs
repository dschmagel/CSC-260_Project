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
            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 27);

            string teamFile = Console.ReadLine();

            List<string> teamList = System.IO.File.ReadAllLines(dir + teamFile).ToList();

            teamList.ForEach(Console.WriteLine);
            Console.WriteLine();

            var CurrentSeason = new Season(teamList, 2, 16);
            List<Standings> playoffTeams = CurrentSeason.simSeason();

            var CurrentPlayoffs = new Playoffs(playoffTeams, 16, 5);
            CurrentPlayoffs.simPlayoffs();



            Console.ReadLine();


        }
    }
}
