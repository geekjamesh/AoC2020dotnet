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
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed_AndRatioIs1_1()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees(1, 1);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed_AndRatioIs3_1()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees(3, 1);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed_AndRatioIs5_1()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees(5, 1);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed_AndRatioIs7_1()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees(7, 1);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Return7_From_CheckRouteForTrees_WhenSampleMapUsed_AndRatioIs1_2()
        {
            var mapper = new Mapper(testMapInput);
            var result = mapper.CheckRouteForTrees(1, 2);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultipleTogetherCorrectly()
        {
            var mapper = new Mapper(testMapInput);
            var result1 = mapper.CheckRouteForTrees(1, 1);
            var result2 = mapper.CheckRouteForTrees(3, 1);
            var result3 = mapper.CheckRouteForTrees(5, 1);
            var result4 = mapper.CheckRouteForTrees(7, 1);
            var result5 = mapper.CheckRouteForTrees(1, 2);
            Assert.Equal(336, result1 * result2 * result3 * result4 * result5);
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
