using System;
using System.Collections.Generic;
using System.IO;

namespace me.jamesharvey.advent._2020.day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2020 Advent of Code - Day 3 - Toboggan Trajectory");
            List<string> inputValues = new List<string>();
            using (var reader = new StreamReader("input.txt"))
            {
                string item = reader.ReadLine();
                while(item != null) {
                    inputValues.Add(item);
                    item = reader.ReadLine();
                }
            }
            try
            {
                var mapper = new Mapper(inputValues);
                long result1 = mapper.CheckRouteForTrees(1, 1);
                long result2 = mapper.CheckRouteForTrees(3, 1);
                long result3 = mapper.CheckRouteForTrees(5, 1);
                long result4 = mapper.CheckRouteForTrees(7, 1);
                long result5 = mapper.CheckRouteForTrees(1, 2);
                long result = result1 * result2 * result3 * result4 * result5;
                
                Console.WriteLine($"Answer = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
        }

        
    }
}
