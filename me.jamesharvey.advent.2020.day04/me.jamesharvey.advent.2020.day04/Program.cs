using System.Collections.Generic;
using System;

namespace me.jamesharvey.advent._2020.day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2020 Advent of Code - Day 4 - Passport Processing");
            List<string> inputValues = new List<string>();
            
            try
            {
                List<Passport> passports = PassportLoader.LoadPassports("input.txt");
                
                var result = 0;
                
                foreach (Passport passport in passports) {
                    if (passport.IsValid) {
                        result += 1;
                    }
                }

                Console.WriteLine($"Answer = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
        }
    }
}
