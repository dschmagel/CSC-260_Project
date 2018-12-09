using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeySimConsole
{
    class Playoffs
    {
        List<Standings> Teams { get; set; }
        int BracketSize { get; set; }
        int GamesPerSeries { get; set; }
        public PlayoffTeam Champion { get; set; } 

        public Playoffs(List<Standings> teams, int bracketSize, int gamesPerSeries )
        {
            this.Teams = teams;
            this.BracketSize = bracketSize;
            this.GamesPerSeries = gamesPerSeries;
        }

        public void simPlayoffs()
        {
            string dir = System.AppContext.BaseDirectory;
            dir = dir.Substring(0, dir.Length - 27);

            string date = DateTime.Now.ToString("yyyy-MM-dd--HH-mm");
            string folder = dir + "HS_Playoffs-" + date;
            System.IO.Directory.CreateDirectory(folder);
            string playoffsPath = folder + "/" + "Playoffs.txt";

            List<PlayoffTeam> playoffTeamNames = new List<PlayoffTeam>();

            int i = 1;
            foreach (Standings p in Teams)
            {
                playoffTeamNames.Add(new PlayoffTeam(p.TeamName, i));
                i++;
            }

            if (BracketSize == 4)
            {
                PlayoffTeam seed1 = playoffTeamNames.Single(s => s.Seed == 1);
                PlayoffTeam seed2 = playoffTeamNames.Single(s => s.Seed == 2);
                PlayoffTeam seed3 = playoffTeamNames.Single(s => s.Seed == 3);
                PlayoffTeam seed4 = playoffTeamNames.Single(s => s.Seed == 4);
                PlayoffTeam finals1;
                PlayoffTeam finals2;

                System.IO.File.AppendAllText(playoffsPath, "Semifinals");
                Console.WriteLine(Environment.NewLine + "Semifinals");
                PlayoffRound semiFinalR1 = new PlayoffRound(seed4, seed1, GamesPerSeries, playoffsPath);
                semiFinalR1.simRound();

                if (semiFinalR1.SeriesWinner == 1)
                {
                    finals1 = seed4;
                    System.IO.File.AppendAllText(playoffsPath, seed4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                    Console.WriteLine(seed4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                }
                else
                {
                    finals1 = seed1;
                    System.IO.File.AppendAllText(playoffsPath, seed1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                    Console.WriteLine(seed1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                }

                PlayoffRound semiFinalR2 = new PlayoffRound(seed3, seed2, GamesPerSeries, playoffsPath);
                semiFinalR2.simRound();

                if (semiFinalR2.SeriesWinner == 1)
                {
                    finals2 = seed3;
                    System.IO.File.AppendAllText(playoffsPath, seed3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                    Console.WriteLine(seed3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                }

                else
                {
                    finals2 = seed2;
                    System.IO.File.AppendAllText(playoffsPath, seed2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                    Console.WriteLine(seed2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                }



                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + "Finals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Finals");

                PlayoffRound finalR = new PlayoffRound(finals2, finals1, GamesPerSeries, playoffsPath);
                finalR.simRound();

                if (finalR.SeriesWinner == 1)
                {
                    Champion = finals2;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);

                }

                else
                {
                    Champion = finals1;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);

                }

            }

            if (BracketSize == 8)
            {
                PlayoffTeam seed1 = playoffTeamNames.Single(s => s.Seed == 1);
                PlayoffTeam seed2 = playoffTeamNames.Single(s => s.Seed == 2);
                PlayoffTeam seed3 = playoffTeamNames.Single(s => s.Seed == 3);
                PlayoffTeam seed4 = playoffTeamNames.Single(s => s.Seed == 4);
                PlayoffTeam seed5 = playoffTeamNames.Single(s => s.Seed == 5);
                PlayoffTeam seed6 = playoffTeamNames.Single(s => s.Seed == 6);
                PlayoffTeam seed7 = playoffTeamNames.Single(s => s.Seed == 7);
                PlayoffTeam seed8 = playoffTeamNames.Single(s => s.Seed == 8);
                PlayoffTeam semifinals1;
                PlayoffTeam semifinals2;
                PlayoffTeam semifinals3;
                PlayoffTeam semifinals4;
                PlayoffTeam finals1;
                PlayoffTeam finals2;

                System.IO.File.AppendAllText(playoffsPath, "Quarterfinals");
                Console.WriteLine(Environment.NewLine + "Quarterfinals");

                PlayoffRound quarterFinalR1 = new PlayoffRound(seed8, seed1, GamesPerSeries, playoffsPath);
                quarterFinalR1.simRound();

                if (quarterFinalR1.SeriesWinner == 1)
                {
                    semifinals1 = seed8;
                    System.IO.File.AppendAllText(playoffsPath, seed8.TeamName + ": " + quarterFinalR1.Team1Wins + "-" + quarterFinalR1.Team2Wins);
                    Console.WriteLine(seed8.TeamName + ": " + quarterFinalR1.Team1Wins + "-" + quarterFinalR1.Team2Wins);
                }
                else
                {
                    semifinals1 = seed1;
                    System.IO.File.AppendAllText(playoffsPath, seed1.TeamName + ": " + quarterFinalR1.Team2Wins + "-" + quarterFinalR1.Team1Wins);
                    Console.WriteLine(seed1.TeamName + ": " + quarterFinalR1.Team2Wins + "-" + quarterFinalR1.Team1Wins);
                }

                PlayoffRound quarterFinalR2 = new PlayoffRound(seed5, seed4, GamesPerSeries, playoffsPath);
                quarterFinalR2.simRound();

                if (quarterFinalR2.SeriesWinner == 1)
                {
                    semifinals4 = seed5;
                    System.IO.File.AppendAllText(playoffsPath, seed5.TeamName + ": " + quarterFinalR2.Team1Wins + "-" + quarterFinalR2.Team2Wins);
                    Console.WriteLine(seed5.TeamName + ": " + quarterFinalR2.Team1Wins + "-" + quarterFinalR2.Team2Wins);
                }

                else
                {
                    semifinals4 = seed4;
                    System.IO.File.AppendAllText(playoffsPath, seed4.TeamName + ": " + quarterFinalR2.Team2Wins + "-" + quarterFinalR2.Team1Wins);
                    Console.WriteLine(seed4.TeamName + ": " + quarterFinalR2.Team2Wins + "-" + quarterFinalR2.Team1Wins);
                }

                PlayoffRound quarterFinalR3 = new PlayoffRound(seed7, seed2, GamesPerSeries, playoffsPath);
                quarterFinalR3.simRound();

                if (quarterFinalR3.SeriesWinner == 1)
                {
                    semifinals2 = seed7;
                    System.IO.File.AppendAllText(playoffsPath, seed7.TeamName + ": " + quarterFinalR3.Team1Wins + "-" + quarterFinalR3.Team2Wins);
                    Console.WriteLine(seed7.TeamName + ": " + quarterFinalR3.Team1Wins + "-" + quarterFinalR3.Team2Wins);
                }
                else
                {
                    semifinals2 = seed2;
                    System.IO.File.AppendAllText(playoffsPath, seed2.TeamName + ": " + quarterFinalR3.Team2Wins + "-" + quarterFinalR3.Team1Wins);
                    Console.WriteLine(seed2.TeamName + ": " + quarterFinalR3.Team2Wins + "-" + quarterFinalR3.Team1Wins);
                }

                PlayoffRound quarterFinalR4 = new PlayoffRound(seed6, seed3, GamesPerSeries, playoffsPath);
                quarterFinalR4.simRound();

                if (quarterFinalR4.SeriesWinner == 1)
                {
                    semifinals3 = seed6;
                    System.IO.File.AppendAllText(playoffsPath, seed6.TeamName + ": " + quarterFinalR4.Team1Wins + "-" + quarterFinalR4.Team2Wins);
                    Console.WriteLine(seed6.TeamName + ": " + quarterFinalR4.Team1Wins + "-" + quarterFinalR4.Team2Wins);
                }

                else
                {
                    semifinals3 = seed3;
                    System.IO.File.AppendAllText(playoffsPath, "");
                    Console.WriteLine(seed3.TeamName + ": " + quarterFinalR4.Team2Wins + "-" + quarterFinalR4.Team1Wins);
                }



                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + Environment.NewLine + "Semifinals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Semifinals");

                PlayoffRound semiFinalR1 = new PlayoffRound(semifinals4, semifinals1, GamesPerSeries, playoffsPath);
                semiFinalR1.simRound();

                if (semiFinalR1.SeriesWinner == 1)
                {
                    finals1 = semifinals4;
                    System.IO.File.AppendAllText(playoffsPath, semifinals4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                    Console.WriteLine(semifinals4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                }
                else
                {
                    finals1 = semifinals1;
                    System.IO.File.AppendAllText(playoffsPath, semifinals1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                    Console.WriteLine(semifinals1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                }

                PlayoffRound semiFinalR2 = new PlayoffRound(semifinals3, semifinals2, GamesPerSeries, playoffsPath);
                semiFinalR2.simRound();

                if (semiFinalR2.SeriesWinner == 1)
                {
                    finals2 = semifinals3;
                    System.IO.File.AppendAllText(playoffsPath, semifinals3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                    Console.WriteLine(semifinals3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                }
                else
                {
                    finals2 = semifinals2;
                    System.IO.File.AppendAllText(playoffsPath, semifinals2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                    Console.WriteLine(semifinals2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                }


                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + "Finals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Finals" + Environment.NewLine);

                PlayoffRound finalR = new PlayoffRound(finals2, finals1, GamesPerSeries, playoffsPath);
                finalR.simRound();

                if (finalR.SeriesWinner == 1)
                {
                    Champion = finals2;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);

                }

                else
                {
                    Champion = finals1;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);

                }

            }

            if (BracketSize == 16)
            {
                PlayoffTeam seed1 = playoffTeamNames.Single(s => s.Seed == 1);
                PlayoffTeam seed2 = playoffTeamNames.Single(s => s.Seed == 2);
                PlayoffTeam seed3 = playoffTeamNames.Single(s => s.Seed == 3);
                PlayoffTeam seed4 = playoffTeamNames.Single(s => s.Seed == 4);
                PlayoffTeam seed5 = playoffTeamNames.Single(s => s.Seed == 5);
                PlayoffTeam seed6 = playoffTeamNames.Single(s => s.Seed == 6);
                PlayoffTeam seed7 = playoffTeamNames.Single(s => s.Seed == 7);
                PlayoffTeam seed8 = playoffTeamNames.Single(s => s.Seed == 8);
                PlayoffTeam seed9 = playoffTeamNames.Single(s => s.Seed == 9);
                PlayoffTeam seed10 = playoffTeamNames.Single(s => s.Seed == 10);
                PlayoffTeam seed11 = playoffTeamNames.Single(s => s.Seed == 11);
                PlayoffTeam seed12 = playoffTeamNames.Single(s => s.Seed == 12);
                PlayoffTeam seed13 = playoffTeamNames.Single(s => s.Seed == 13);
                PlayoffTeam seed14 = playoffTeamNames.Single(s => s.Seed == 14);
                PlayoffTeam seed15 = playoffTeamNames.Single(s => s.Seed == 15);
                PlayoffTeam seed16 = playoffTeamNames.Single(s => s.Seed == 16);
                PlayoffTeam quarterfinals1;
                PlayoffTeam quarterfinals2;
                PlayoffTeam quarterfinals3;
                PlayoffTeam quarterfinals4;
                PlayoffTeam quarterfinals5;
                PlayoffTeam quarterfinals6;
                PlayoffTeam quarterfinals7;
                PlayoffTeam quarterfinals8;
                PlayoffTeam semifinals1;
                PlayoffTeam semifinals2;
                PlayoffTeam semifinals3;
                PlayoffTeam semifinals4;
                PlayoffTeam finals1;
                PlayoffTeam finals2;

                System.IO.File.AppendAllText(playoffsPath, "Round of 16");
                Console.WriteLine(Environment.NewLine + "Round of 16");

                PlayoffRound roundOf16R1 = new PlayoffRound(seed16, seed1, GamesPerSeries, playoffsPath);
                roundOf16R1.simRound();

                if (roundOf16R1.SeriesWinner == 1)
                {
                    quarterfinals1 = seed16;
                    System.IO.File.AppendAllText(playoffsPath, seed16.TeamName + ": " + roundOf16R1.Team1Wins + "-" + roundOf16R1.Team2Wins);
                    Console.WriteLine(seed16.TeamName + ": " + roundOf16R1.Team1Wins + "-" + roundOf16R1.Team2Wins);
                }
                else
                {
                    quarterfinals1 = seed1;
                    System.IO.File.AppendAllText(playoffsPath, seed1.TeamName + ": " + roundOf16R1.Team2Wins + "-" + roundOf16R1.Team1Wins);
                    Console.WriteLine(seed1.TeamName + ": " + roundOf16R1.Team2Wins + "-" + roundOf16R1.Team1Wins);
                }

                PlayoffRound roundOf16R2 = new PlayoffRound(seed9, seed8, GamesPerSeries, playoffsPath);
                roundOf16R2.simRound();

                if (roundOf16R2.SeriesWinner == 1)
                {
                    quarterfinals8 = seed9;
                    System.IO.File.AppendAllText(playoffsPath, seed9.TeamName + ": " + roundOf16R2.Team1Wins + "-" + roundOf16R2.Team2Wins);
                    Console.WriteLine(seed9.TeamName + ": " + roundOf16R2.Team1Wins + "-" + roundOf16R2.Team2Wins);
                }

                else
                {
                    quarterfinals8 = seed8;
                    System.IO.File.AppendAllText(playoffsPath, seed8.TeamName + ": " + roundOf16R2.Team2Wins + "-" + roundOf16R2.Team1Wins);
                    Console.WriteLine(seed8.TeamName + ": " + roundOf16R2.Team2Wins + "-" + roundOf16R2.Team1Wins);
                }

                PlayoffRound roundOf16R3 = new PlayoffRound(seed13, seed4, GamesPerSeries, playoffsPath);
                roundOf16R3.simRound();

                if (roundOf16R3.SeriesWinner == 1)
                {
                    quarterfinals4 = seed13;
                    System.IO.File.AppendAllText(playoffsPath, seed13.TeamName + ": " + roundOf16R3.Team1Wins + "-" + roundOf16R3.Team2Wins);
                    Console.WriteLine(seed13.TeamName + ": " + roundOf16R3.Team1Wins + "-" + roundOf16R3.Team2Wins);
                }
                else
                {
                    quarterfinals4  = seed4;
                    System.IO.File.AppendAllText(playoffsPath, seed4.TeamName + ": " + roundOf16R3.Team2Wins + "-" + roundOf16R3.Team1Wins);
                    Console.WriteLine(seed4.TeamName + ": " + roundOf16R3.Team2Wins + "-" + roundOf16R3.Team1Wins);
                }

                PlayoffRound roundOf16R4 = new PlayoffRound(seed12, seed5, GamesPerSeries, playoffsPath);
                roundOf16R4.simRound();

                if (roundOf16R4.SeriesWinner == 1)
                {
                    quarterfinals5 = seed12;
                    System.IO.File.AppendAllText(playoffsPath, seed12.TeamName + ": " + roundOf16R4.Team1Wins + "-" + roundOf16R4.Team2Wins);
                    Console.WriteLine(seed12.TeamName + ": " + roundOf16R4.Team1Wins + "-" + roundOf16R4.Team2Wins);
                }

                else
                {
                    quarterfinals5 = seed5;
                    System.IO.File.AppendAllText(playoffsPath, seed5.TeamName + ": " + roundOf16R4.Team2Wins + "-" + roundOf16R4.Team1Wins);
                    Console.WriteLine(seed5.TeamName + ": " + roundOf16R4.Team2Wins + "-" + roundOf16R4.Team1Wins);
                }

                PlayoffRound roundOf16R5 = new PlayoffRound(seed15, seed2, GamesPerSeries, playoffsPath);
                roundOf16R5.simRound();

                if (roundOf16R5.SeriesWinner == 1)
                {
                    quarterfinals2 = seed15;
                    System.IO.File.AppendAllText(playoffsPath, seed15.TeamName + ": " + roundOf16R5.Team1Wins + "-" + roundOf16R5.Team2Wins);
                    Console.WriteLine(seed15.TeamName + ": " + roundOf16R5.Team1Wins + "-" + roundOf16R5.Team2Wins);
                }
                else
                {
                    quarterfinals2 = seed2;
                    System.IO.File.AppendAllText(playoffsPath, seed2.TeamName + ": " + roundOf16R5.Team2Wins + "-" + roundOf16R5.Team1Wins);
                    Console.WriteLine(seed2.TeamName + ": " + roundOf16R5.Team2Wins + "-" + roundOf16R5.Team1Wins);
                }

                PlayoffRound roundOf16R6 = new PlayoffRound(seed10, seed7, GamesPerSeries, playoffsPath);
                roundOf16R6.simRound();

                if (roundOf16R6.SeriesWinner == 1)
                {
                    quarterfinals7 = seed10;
                    System.IO.File.AppendAllText(playoffsPath, seed10.TeamName + ": " + roundOf16R6.Team1Wins + "-" + roundOf16R6.Team2Wins);
                    Console.WriteLine(seed10.TeamName + ": " + roundOf16R6.Team1Wins + "-" + roundOf16R6.Team2Wins);
                }

                else
                {
                    quarterfinals7 = seed7;
                    System.IO.File.AppendAllText(playoffsPath, seed7.TeamName + ": " + roundOf16R6.Team2Wins + "-" + roundOf16R6.Team1Wins);
                    Console.WriteLine(seed7.TeamName + ": " + roundOf16R6.Team2Wins + "-" + roundOf16R6.Team1Wins);
                }

                PlayoffRound roundOf16R7 = new PlayoffRound(seed14, seed3, GamesPerSeries, playoffsPath);
                roundOf16R7.simRound();

                if (roundOf16R7.SeriesWinner == 1)
                {
                    quarterfinals3 = seed14;
                    System.IO.File.AppendAllText(playoffsPath, seed14.TeamName + ": " + roundOf16R7.Team1Wins + "-" + roundOf16R7.Team2Wins);
                    Console.WriteLine(seed14.TeamName + ": " + roundOf16R7.Team1Wins + "-" + roundOf16R7.Team2Wins);
                }
                else
                {
                    quarterfinals3 = seed3;
                    System.IO.File.AppendAllText(playoffsPath, seed3.TeamName + ": " + roundOf16R7.Team2Wins + "-" + roundOf16R7.Team1Wins);
                    Console.WriteLine(seed3.TeamName + ": " + roundOf16R7.Team2Wins + "-" + roundOf16R7.Team1Wins);
                }

                PlayoffRound roundOf16R8 = new PlayoffRound(seed11, seed6, GamesPerSeries, playoffsPath);
                roundOf16R8.simRound();

                if (roundOf16R8.SeriesWinner == 1)
                {
                    quarterfinals6 = seed11;
                    System.IO.File.AppendAllText(playoffsPath, seed11.TeamName + ": " + roundOf16R8.Team1Wins + "-" + roundOf16R8.Team2Wins);
                    Console.WriteLine(seed11.TeamName + ": " + roundOf16R8.Team1Wins + "-" + roundOf16R8.Team2Wins);
                }

                else
                {
                    quarterfinals6 = seed6;
                    System.IO.File.AppendAllText(playoffsPath, seed6.TeamName + ": " + roundOf16R8.Team2Wins + "-" + roundOf16R8.Team1Wins);
                    Console.WriteLine(seed6.TeamName + ": " + roundOf16R8.Team2Wins + "-" + roundOf16R8.Team1Wins);
                }



                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + Environment.NewLine + "Quarterfinals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Quarterfinals");

                PlayoffRound quarterFinalR1 = new PlayoffRound(quarterfinals8, quarterfinals1, GamesPerSeries, playoffsPath);
                quarterFinalR1.simRound();

                if (quarterFinalR1.SeriesWinner == 1)
                {
                    semifinals1 = quarterfinals8;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals8.TeamName + ": " + quarterFinalR1.Team1Wins + "-" + quarterFinalR1.Team2Wins);
                    Console.WriteLine(quarterfinals8.TeamName + ": " + quarterFinalR1.Team1Wins + "-" + quarterFinalR1.Team2Wins);
                }
                else
                {
                    semifinals1 = quarterfinals1;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals1.TeamName + ": " + quarterFinalR1.Team2Wins + "-" + quarterFinalR1.Team1Wins);
                    Console.WriteLine(quarterfinals1.TeamName + ": " + quarterFinalR1.Team2Wins + "-" + quarterFinalR1.Team1Wins);
                }

                PlayoffRound quarterFinalR2 = new PlayoffRound(quarterfinals5, quarterfinals4, GamesPerSeries, playoffsPath);
                quarterFinalR2.simRound();

                if (quarterFinalR2.SeriesWinner == 1)
                {
                    semifinals4 = quarterfinals5;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals5.TeamName + ": " + quarterFinalR2.Team1Wins + "-" + quarterFinalR2.Team2Wins);
                    Console.WriteLine(quarterfinals5.TeamName + ": " + quarterFinalR2.Team1Wins + "-" + quarterFinalR2.Team2Wins);
                }

                else
                {
                    semifinals4 = quarterfinals4;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals4.TeamName + ": " + quarterFinalR2.Team2Wins + "-" + quarterFinalR2.Team1Wins);
                    Console.WriteLine(quarterfinals4.TeamName + ": " + quarterFinalR2.Team2Wins + "-" + quarterFinalR2.Team1Wins);
                }

                PlayoffRound quarterFinalR3 = new PlayoffRound(quarterfinals7, quarterfinals2, GamesPerSeries, playoffsPath);
                quarterFinalR3.simRound();

                if (quarterFinalR3.SeriesWinner == 1)
                {
                    semifinals2 = quarterfinals7;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals7.TeamName + ": " + quarterFinalR3.Team1Wins + "-" + quarterFinalR3.Team2Wins);
                    Console.WriteLine(quarterfinals7.TeamName + ": " + quarterFinalR3.Team1Wins + "-" + quarterFinalR3.Team2Wins);
                }
                else
                {
                    semifinals2 = quarterfinals2;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals2.TeamName + ": " + quarterFinalR3.Team2Wins + "-" + quarterFinalR3.Team1Wins);
                    Console.WriteLine(quarterfinals2.TeamName + ": " + quarterFinalR3.Team2Wins + "-" + quarterFinalR3.Team1Wins);
                }

                PlayoffRound quarterFinalR4 = new PlayoffRound(quarterfinals6, quarterfinals3, GamesPerSeries, playoffsPath);
                quarterFinalR4.simRound();

                if (quarterFinalR4.SeriesWinner == 1)
                {
                    semifinals3 = quarterfinals6;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals6.TeamName + ": " + quarterFinalR4.Team1Wins + "-" + quarterFinalR4.Team2Wins);
                    Console.WriteLine(quarterfinals6.TeamName + ": " + quarterFinalR4.Team1Wins + "-" + quarterFinalR4.Team2Wins);
                }

                else
                {
                    semifinals3 = quarterfinals3;
                    System.IO.File.AppendAllText(playoffsPath, quarterfinals3.TeamName + ": " + quarterFinalR4.Team2Wins + "-" + quarterFinalR4.Team1Wins);
                    Console.WriteLine(quarterfinals3.TeamName + ": " + quarterFinalR4.Team2Wins + "-" + quarterFinalR4.Team1Wins);
                }



                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + Environment.NewLine + "Semifinals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine + "Semifinals");

                PlayoffRound semiFinalR1 = new PlayoffRound(semifinals4, semifinals1, GamesPerSeries, playoffsPath);
                semiFinalR1.simRound();

                if (semiFinalR1.SeriesWinner == 1)
                {
                    finals1 = semifinals4;
                    System.IO.File.AppendAllText(playoffsPath, semifinals4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                    Console.WriteLine(semifinals4.TeamName + ": " + semiFinalR1.Team1Wins + "-" + semiFinalR1.Team2Wins);
                }
                else
                {
                    finals1 = semifinals1;
                    System.IO.File.AppendAllText(playoffsPath, semifinals1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                    Console.WriteLine(semifinals1.TeamName + ": " + semiFinalR1.Team2Wins + "-" + semiFinalR1.Team1Wins);
                }

                PlayoffRound semiFinalR2 = new PlayoffRound(semifinals3, semifinals2, GamesPerSeries, playoffsPath);
                semiFinalR2.simRound();

                if (semiFinalR2.SeriesWinner == 1)
                {
                    finals2 = semifinals3;
                    System.IO.File.AppendAllText(playoffsPath, semifinals3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                    Console.WriteLine(semifinals3.TeamName + ": " + semiFinalR2.Team1Wins + "-" + semiFinalR2.Team2Wins);
                }

                else
                {
                    finals2 = semifinals2;
                    System.IO.File.AppendAllText(playoffsPath, semifinals2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                    Console.WriteLine(semifinals2.TeamName + ": " + semiFinalR2.Team2Wins + "-" + semiFinalR2.Team1Wins);
                }


                System.IO.File.AppendAllText(playoffsPath, Environment.NewLine + Environment.NewLine + "Finals" + Environment.NewLine);
                Console.WriteLine(Environment.NewLine +  "Finals");

                PlayoffRound finalR = new PlayoffRound(finals2, finals1, GamesPerSeries, playoffsPath);
                finalR.simRound();

                if (finalR.SeriesWinner == 1)
                {
                    Champion = finals2;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team1Wins + "-" + finalR.Team2Wins);

                }

                else
                {
                    Champion = finals1;
                    System.IO.File.AppendAllText(playoffsPath, Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);
                    Console.WriteLine(Champion.TeamName + ": " + finalR.Team2Wins + "-" + finalR.Team1Wins);

                }

            }
        }
    }
}
