﻿using AdventOfCode2016.Solvers;
using NUnit.Framework;

namespace AdventOfCodeTests.Solvers
{
    internal class Day3Solver_should_
    {
        [TestCase("3 4 5")]
        [TestCase("   3 4  5 ")]
        public void parse_input_with_various_spacing(string input)
        {
            var actualResult = Day3Solver.CreateForPart1().GetSolution(input);
            Assert.AreEqual(1, actualResult);
        }

        [Test]
        public void count_possible_triangles()
        {
            var input = "3 4 5\n1 2 3\n5 6 7";
            var actualResult = Day3Solver.CreateForPart1().GetSolution(input);
            Assert.AreEqual(2, actualResult);
        }

        [Test]
        public void interpret_triangles_from_columns_in_part_2()
        {
            var input = "3 1 5\n4 2 6\n5 3 7";
            var actualResult = Day3Solver.CreateForPart2().GetSolution(input);
            Assert.AreEqual(2, actualResult);
        }
    }
}
