using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cals = File.ReadAllText(@"C:\\Users\\Toby\\source\repos\\Advent Of Code 2022\\Day 1\\input.txt").Split("\n\n").ToList();
            
            List<int> elfCallories = new List<int>();
            for (int i = 0; i < cals.Count - 1; i++)
            {
                elfCallories.Add(cals[i].Split("\n").Select(int.Parse).ToArray().Sum());
            }
            var top3 = elfCallories.GroupBy(x => x)
                 .Select(x => x.OrderByDescending(y => y).First())
                 .OrderByDescending(x => x)
                 .ThenBy(x => x)
                 .Take(3).Sum(); //Take 1 for part 1 answer 
            Console.WriteLine(top3);
        }
    }
}
