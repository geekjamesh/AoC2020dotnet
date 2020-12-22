using System;
using System.Collections.Generic;
using Xunit;

namespace me.jamesharvey.advent._2020.day03.test
{
    public class MapperShould
    {
        [Fact]
        public void Return1_From_IsTreeEncountered_WhenMapShowsTree()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.IsTreeEncountered(testMapInput[0][2]);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Return0_From_IsTreeEncountered_WhenMapShowsNotATree()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.IsTreeEncountered(testMapInput[0][1]);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees();
            Assert.Equal(7, result);
        }


        private readonly List<string> testMapInput = new List<string> {
            "..##.......",
            "#...#...#..",
            ".#....#..#.",
            "..#.#...#.#",
            ".#...##..#.",
            "..#.##.....",
            ".#.#.#....#",
            ".#........#",
            "#.##...#...",
            "#...##....#",
            ".#..#...#.#"
        };
    }
}
