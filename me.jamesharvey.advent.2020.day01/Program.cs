using System;
using System.Collections.Generic;

namespace me.jamesharvey.advent._2020.day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Values, press q to quit");
            List<string> inputValues = new List<string>();
            var input = Console.ReadLine();
            while (input != "q" && input != "Q") {
                inputValues.Add(input);
                input = Console.ReadLine();
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
