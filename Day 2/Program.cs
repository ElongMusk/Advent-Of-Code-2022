using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = File.ReadAllText(@"C:\\Users\\Toby\\source\repos\\Advent Of Code 2022\\Day 2\\input.txt")
                .Split("\n")
                .ToList();

            int totalPoints = 0;
            foreach (var game in games)
            {
                if(game != "")
                {
                    char yourChoice = game[^1],
                    oppositionChoice = game[0];

                    totalPoints += CalcualteRoundScore(yourChoice, oppositionChoice);
                }
                
            }

            Console.WriteLine(totalPoints);
        }

        static int CalcualteRoundScore(char myChoice, char opChoice)
        {
            int score = 0;
            switch (myChoice)
            {
                case 'X':
                    score += 1;
                    switch (opChoice)
                    {
                        case 'A': return score += 3;

                        case 'B': return score += 0;

                        case 'C': return score += 6;
                    }
                    break;
                case 'Y':
                    score += 2;
                    switch (opChoice)
                    {
                        case 'A': return score += 6;

                        case 'B': return score += 3;

                        case 'C': return score += 0;
                    }
                    break;
                case 'Z':
                    score += 3;
                    switch (opChoice)
                    {
                        case 'A': return score += 0;

                        case 'B': return score += 6;

                        case 'C': return score += 3;
                    }
                    return score;
            }
            return 0;
        }
    }
}
