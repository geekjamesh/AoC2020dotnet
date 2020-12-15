using System;
using System.Collections.Generic;
using System.IO;

namespace me.jamesharvey.advent._2020.day01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputValues = new List<string>();
            var input = Console.ReadLine();
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
                var result = new ExpenseReport(2020).CalculateExpenseValue(inputValues);
                Console.WriteLine($"Answer = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
            
        }
    }
}
