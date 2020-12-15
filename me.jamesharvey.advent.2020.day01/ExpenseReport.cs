using System.Collections.Generic;
using System;

namespace me.jamesharvey.advent._2020.day01
{
    public class ExpenseReport {
        private int expectedValue;
        public ExpenseReport(int expectedValue) {
            this.expectedValue = expectedValue;
        }

        public int CalculateExpenseValue(List<string> input){
            var values = FindValues(input);
            return MultiplyValues(values);
        }

        public List<int> FindValues(List<string> input) {
            List<int> results = new List<int>();
            try
            {
                for(int outerIndex = 0; outerIndex < input.Count; outerIndex+=1){
                    var value1 = int.Parse(input[outerIndex]);
                    for(int innerIndex = outerIndex + 1; innerIndex < input.Count; innerIndex+=1){
                        var value2 = int.Parse(input[innerIndex]);

                        if (value1 + value2 == expectedValue) {
                            results.Add(value1);
                            results.Add(value2);
                            return results;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            } 
            return results;
        }

        public int MultiplyValues(List<int> values){
            int result = 0;
            foreach (int value in values){
                if (result == 0) {
                    result = value;
                }
                else {
                    result = result * value;
                }
            }

            return result;
        }
    }

}