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
            List<string> games = File.ReadAllText(@"C:\Users\Toby\Source\Repos\Advent-Of-Code-2022\Day 2\input.txt")
                .Split("\r\n")
                .ToList();

            int totalPoints1 = 0;
            int totalPoints2 = 0;
            foreach (var game in games)
            {
                if(game != "")
                {
                    char yourChoice = game[^1],
                    oppositionChoice = game[0];

                    totalPoints1 += CalcualteRoundScore(yourChoice, oppositionChoice);
                    totalPoints2 += CalculateRoundChoice(yourChoice, oppositionChoice);
                }
            }

            Console.WriteLine(totalPoints1 + " " + totalPoints2);
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


        static int CalculateRoundChoice(char myChoice, char opChoice)
        {
            int score = 0;
            switch (opChoice)
            {
                case 'A':
                    switch (myChoice)
                    {
                        case 'X': return score += 3; 

                        case 'Y': return score += 4;

                        case 'Z': return score += 8;
                    }
                    break;
                case 'B':
                    switch (myChoice)
                    {
                        case 'X': return score += 1;

                        case 'Y': return score += 5;

                        case 'Z': return score += 9;
                    }
                    break;
                case 'C':
                    switch (myChoice)
                    {
                        case 'X': return score += 2;

                        case 'Y': return score += 6;

                        case 'Z': return score += 7;
                    }
                    return score;
            }


            return 0;
        }
    }
}
