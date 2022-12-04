using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_1
{
    class Program
    {
        static void Main()
        {
            List<string> cals = File.ReadAllText(@"C:\\Users\\Toby\\source\repos\\Advent Of Code 2022\\Day 1\\input.txt").Split("\n\n").ToList();
            
            List<int> elfCallories = new List<int>();
            for (int i = 0; i < cals.Count - 1; i++)
            {
                elfCallories.Add(cals[i].Split("\n").Select(int.Parse).ToArray().Sum());
            }
            
            int TOTAL = elfCallories.OrderByDescending(i => i)
                .Take(3)
                .Sum();
            Console.WriteLine(TOTAL);
        }
    }
}
