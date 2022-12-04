using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_4
{
    class Program
    {
        static void Main()
        {
            List<string> pairs = File.ReadAllText(@"C:\Users\Toby\Source\Repos\Advent-Of-Code-2022\Day 4\input.txt")
                .Split("\n")
                .ToList();

            int total = 0;
            int total2 = 0;
            for (int i = 0; i < pairs.Count -1; i++)
            {
                int[] num = Array.ConvertAll(pairs[i].Split(new string[] { ",", "-" }, 
                    StringSplitOptions.None), int.Parse);
                
                if(num[0] >= num[2] && num[1] <= num[3] 
                    || num[2] >= num[0] && num[3] <= num[1])
                {
                    total++;
                }
                if(num[0] <= num[3] && num[2] <= num[1])
                {
                    total2++;
                }
            }
            Console.WriteLine(total2);
        }
    }
}
