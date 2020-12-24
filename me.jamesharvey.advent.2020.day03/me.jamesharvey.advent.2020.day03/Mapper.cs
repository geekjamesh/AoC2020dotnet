using System.Collections.Generic;
using System;

namespace me.jamesharvey.advent._2020.day03
{
    public class Mapper {

        private readonly List<string> map;

        public Mapper(List<string> map) {
            this.map = map;
        }

        public int CheckRouteForTrees(int xAxisStep, int yAxisStep) {
            int trees = 0;
            int xCoOrd = 0;
            for (int index = 0; index < map.Count; index += yAxisStep) {
                string treeLine = map[index];
                while (treeLine.Length <= xCoOrd + 1) {
                    treeLine+=treeLine;
                }

                if (treeLine[xCoOrd] == '#') {
                    trees += 1;
                }
                xCoOrd += xAxisStep;
                
            }
            return trees;
        }

        public int IsTreeEncountered(char marker) {
            if (marker == '#') {
                return 1;
            }
            else {
                return 0;
            }
        }

    }

}