using System;
using System.Collections.Generic;
using Xunit;

namespace me.jamesharvey.advent._2020.day04.test
{
    public class PassportLoaderShould
    {
        [Fact]
        public void Return4Passports_WhenLoadPassportsCalled_WithTestInputFile()
        {
            var passports = PassportLoader.LoadPassports("testInput.txt");
            Assert.Equal(4, passports.Count);
        }
    }
}
