using System;
using System.Collections.Generic;
using Xunit;
using me.jamesharvey.advent._2020.day01;

namespace me.jamesharvey.advent._2020.day01.test
{
    public class ExpenseReportShould
    {
        [Fact]
        public void ReturnCorrectValuesFrom_FindValues_WhenSampleInputProvided()
        {
            List<string> testInput = new List<string>() {"1721", "979", "366", "299", "675", "1456"};
            ExpenseReport report = new ExpenseReport(2020);
            var results = report.FindValues(testInput);
            Assert.Equal(3, results.Count);
            Assert.Equal(979, results[0]);
            Assert.Equal(366, results[1]);
            Assert.Equal(675, results[2]);
        }

        [Fact]
        public void ReturnCorrectValuesFrom_FindValues_WhenSampleInputJumbled()
        {
            List<string> testInput = new List<string>() {"979", "366", "299", "675", "1456", "1721"};
            ExpenseReport report = new ExpenseReport(2020);
            var results = report.FindValues(testInput);
            Assert.Equal(979, results[0]);
            Assert.Equal(366, results[1]);
            Assert.Equal(675, results[2]);
        }
        
        [Fact]
        public void ReturnCorrectAnswerFrom_Multiplyvalues_WhenSampleInputProvided()
        {
            List<int> testInput = new List<int>() {979, 366, 675};
            ExpenseReport report = new ExpenseReport(2020);
            var results = report.MultiplyValues(testInput);
            Assert.Equal(241861950, results);
        }
        
        [Fact]
        public void ReturnCorrectValuesFrom_CalculateExpenseValue_WhenSampleInputProvided()
        {
            List<string> testInput = new List<string>() {"1721", "979", "366", "299", "675", "1456"};
            ExpenseReport report = new ExpenseReport(2020);
            var results = report.CalculateExpenseValue(testInput);
            Assert.Equal(241861950, results);
        }
    }
}
