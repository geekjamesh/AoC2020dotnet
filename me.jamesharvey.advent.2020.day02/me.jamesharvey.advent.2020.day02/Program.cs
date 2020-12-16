using System;
using System.Collections.Generic;
using System.IO;

namespace me.jamesharvey.advent._2020.day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2020 Advent of Code - Day 2 - Password Policy Check");
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
                int result = 0;
                foreach(string inputPassword in inputValues) {
                    var values = inputPassword.Split(": ");
                    if (values.Length == 2) {
                        Password password = new Password(values[0], values[1]);
                        if (password.IsValid) {
                            result += 1;
                        }
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
