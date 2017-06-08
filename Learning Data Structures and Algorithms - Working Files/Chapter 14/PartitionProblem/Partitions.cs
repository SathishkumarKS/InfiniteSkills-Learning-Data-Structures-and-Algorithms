using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace PartitionProblem
{
    public static class Partitions
    {
        // Used for randomized solutions.
        private static Random Rand = new Random();

#region Exhaustive Search

        // Perform an exhaustive search.
        public static void ExhaustiveSearch(int[] values, int[] solution, out int difference)
        {
            int[] testSolution = new int[values.Length];
            difference = int.MaxValue;
            DoExhaustiveSearch(values, 0, testSolution, solution, ref difference);
        }

        // Perform a recursive exhaustive search.
        // Return true if we find a perfect solution.
        private static bool DoExhaustiveSearch(int[] values, int numAssigned, int[] testSolution,
            int[] bestSolution, ref int bestDifference)
        {
            // See if we have a complete assignment.
            if (numAssigned == values.Length)
            {
                // Evaluate this solution.
                int[] totals = new int[2];
                for (int i = 0; i < values.Length; i++) totals[testSolution[i]] += values[i];

                // See if this is an improvement.
                int testDifference = Math.Abs(totals[0] - totals[1]);
                if (testDifference < bestDifference)
                {
                    bestDifference = testDifference;
                    testSolution.CopyTo(bestSolution, 0);
                }
                return (bestDifference == 0);
            }
            else
            {
                // Try adding the next item to set 0.
                testSolution[numAssigned] = 0;
                if (DoExhaustiveSearch(values, numAssigned + 1,
                    testSolution, bestSolution, ref bestDifference))
                        return true;

                // Try adding the next item to set 1.
                testSolution[numAssigned] = 1;
                if (DoExhaustiveSearch(values, numAssigned + 1,
                    testSolution, bestSolution, ref bestDifference))
                        return true;

                // We found no perfect solution from this point.
                return false;
            }
        }

#endregion Exhaustive Search

#region Branch and Bound

        // Perform a branch and bound search.
        public static void BranchAndBound(int[] values, int[] solution, out int difference)
        {
            int[] testSolution = new int[values.Length];
            difference = int.MaxValue;
            DoBranchAndBound(values, 0, testSolution, values.Sum(), 0, 0,
                solution, ref difference);
        }

        // Perform a recursive branch and bound search.
        // Return true if we find a perfect solution.
        private static bool DoBranchAndBound(int[] values, int numAssigned, int[] testSolution,
            int totalUnassigned, int total0, int total1,
            int[] bestSolution, ref int bestDifference)
        {
            // See if we have a complete assignment.
            if (numAssigned == values.Length)
            {
                // If we get here, we have a complete assignment.

                // It should also be an improvement or else we wouldn't have
                // made the final recursive call. But let's make sure. ;-)
                int testDifference = Math.Abs(total0 - total1);
                Debug.Assert(testDifference < bestDifference);

                // Save the new solution.
                bestDifference = testDifference;
                testSolution.CopyTo(bestSolution, 0);
                return (bestDifference == 0);
            }
            else
            {
                // We're going to try to assign this value.
                totalUnassigned -= values[numAssigned];

                // *************
                // *** Set 0 ***
                // *************
                // Try adding the next item to set 0.
                total0 += values[numAssigned];

                // See if that might lead to an improved solution.
                int testDiff = Math.Abs(total0 - total1);
                if (testDiff - totalUnassigned < bestDifference)
                {
                    testSolution[numAssigned] = 0;
                    if (DoBranchAndBound(values, numAssigned + 1, testSolution,
                        totalUnassigned, total0, total1,
                        bestSolution, ref bestDifference))
                            return true;
                }

                // *************
                // *** Set 1 ***
                // *************
                // Try adding the next item to set 0.
                total0 -= values[numAssigned];
                total1 += values[numAssigned];

                // See if that might lead to an improved solution.
                testDiff = Math.Abs(total0 - total1);
                if (testDiff - totalUnassigned < bestDifference)
                {
                    testSolution[numAssigned] = 1;
                    if (DoBranchAndBound(values, numAssigned + 1, testSolution,
                        totalUnassigned, total0, total1,
                        bestSolution, ref bestDifference))
                            return true;
                }

                // Unassign the most recent value.
                total1 -= values[numAssigned];

                // We found no perfect solution from this point.
                return false;
            }
        }

#endregion Branch and Bound

#region Random

        // Use random solutions.
        public static void Random(int[] values, int[] solution, int maxTries, out int difference)
        {
            difference = int.MaxValue;
            int[] testSolution = new int[solution.Length];

            // Perform up to maxTries trials.
            for (int i = 0; i < maxTries; i++)
            {
                // Make a random solution.
                int total0, total1;
                MakeRandomSolution(values, testSolution, out total0, out total1);

                // See if this is an improvement.
                int testDifference = Math.Abs(total0 - total1);
                if (testDifference < difference)
                {
                    testSolution.CopyTo(solution, 0);
                    difference = testDifference;
                    if (difference == 0) return;
                }
            }
        }

        // Make a random assignment.
        private static void MakeRandomSolution(int[] values, int[] solution, out int total0, out int total1)
        {
            total0 = 0;
            total1 = 0;
            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = Rand.Next(0, 2);
                if (solution[i] == 0) total0 += values[i];
                else total1 += values[i];
            }
        }

#endregion Random

#region Random with Swaps

        // Use random solutions with pair swaps.
        public static void RandomWithSwaps(int[] values, int[] solution, int maxTries, out int difference)
        {
            difference = int.MaxValue;
            int[] testSolution = new int[solution.Length];

            // Perform up to maxTries trials.
            for (int i = 0; i < maxTries; i++)
            {
                // Make a random solution.
                int total0, total1;
                MakeRandomSolution(values, testSolution, out total0, out total1);

                // Try to improve the solution with pair swaps.
                TryPairSwaps(values, testSolution, ref total0, ref total1);

                // See if this is an improvement.
                int testDifference = Math.Abs(total0 - total1);
                if (testDifference < difference)
                {
                    testSolution.CopyTo(solution, 0);
                    difference = testDifference;
                    if (difference == 0) return;
                }
            }
        }

        // Try all possible pair swaps to look for improvements.
        // Return true if we find a perfect solution.
        private static bool TryPairSwaps(int[] values, int[] solution, ref int total0, ref int total1)
        {
            int difference = Math.Abs(total0 - total1);
            bool improved = true;
            while (improved)
            {
                improved = false;
                for (int i = 0; i < solution.Length; i++)
                {
                    for (int j = 0; j < solution.Length; j++)
                    {
                        if ((i != j) && (solution[i] != solution[j]))
                        {
                            // See if we should swap values i and j.
                            int change0 = -values[i] + values[j];   // The change to set 0.
                            if (solution[i] == 1) change0 = -change0;
                            int change1 = -change0;
                            int testDifference = Math.Abs((total0 + change0) - (total1 + change1));
                            if (testDifference < difference)
                            {
                                // Keep this change.
                                difference = testDifference;
                                solution[i] = 1 - solution[i];
                                solution[j] = 1 - solution[j];
                                improved = true;

                                // See if this is a perfect solution.
                                if (difference == 0) return true;
                            }
                        }
                    }
                }
            }

            // We're not finding any more improvements and
            // we didn't find a perfect solution.
            return false;
        }

#endregion Random with Swaps

#region Greedy

        // Use a greedy heuristic.
        public static void Greedy(int[] values, int[] solution, out int difference)
        {
            int total0 = 0, total1 = 0;
            for (int i = 0; i < values.Length; i++)
            {
                // Add the next item to the smaller set.
                if (total0 < total1)
                {
                    total0 += values[i];
                    solution[i] = 0;
                }
                else
                {
                    total1 += values[i];
                    solution[i] = 1;
                }
            }
            difference = Math.Abs(total0 - total1);
        }

#endregion Greedy

#region Sorted Greedy

        // Use a sorted greedy heuristic.
        public static void SortedGreedy(int[] values, int[] solution, out int difference)
        {
            // Make a copy of the values so we don't mess up the original array.
            int[] testValues = new int[values.Length];
            values.CopyTo(testValues, 0);

            // Make an array giving the indexes of the values.
            int[] indexes = Enumerable.Range(0, values.Length).ToArray();

            // Sort the values, keeping the indexes in sync with them.
            // When this is done, indexes[i] tells where value i started in the values array.
            Array.Sort(testValues, indexes);

            // Reverse the arrays so we consider items largest-to-smallest.
            Array.Reverse(testValues);
            Array.Reverse(indexes);

            // Use the greedy algorithm to assign the values to the sets.
            int[] testSolution = new int[solution.Length];
            Greedy(testValues, testSolution, out difference);

            // Convert the test solution values for the solutions array.
            for (int i = 0; i < values.Length; i++)
                solution[indexes[i]] = testSolution[i];
        }

#endregion Sorted Greedy

    }
}
