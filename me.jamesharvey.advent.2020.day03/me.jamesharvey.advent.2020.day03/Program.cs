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
                int result = mapper.CheckRouteForTrees();
                
                Console.WriteLine($"Answer = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
        }

        
    }
}
