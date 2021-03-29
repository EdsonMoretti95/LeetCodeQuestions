using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given an integer numRows, return the first numRows of Pascal's triangle.
    /// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown: 
    ///                     1
    ///                 1       1
    ///             1       2       1    
    ///         1       3       3       1
    ///     1       4       6       4       1
    ///     
    /// Example 1:
    /// Input: numRows = 5
    /// Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
    /// 
    /// Example 2:
    /// Input: numRows = 1
    /// Output: [[1]]
    /// 
    /// Constraints:
    /// 1 <= numRows <= 30
    /// </summary>
    class PascalsTriangle
    {
        public static void Solve()
        {
            var solution = Generate(5);

            for (int i = 0; i <= solution.Count-1; i++)
            {
                var s = "";
                for (int j = 0; j <= solution[i].Count-1; j++)
                {
                    s += $", {solution[i][j]}";
                }
                Console.WriteLine(s.Remove(0, 1));
            }
        }

        /// <summary>
        /// Generate the lines of the Pascal's triangle.
        /// Always add the first one and then loop from 1 to numRows adding the next line
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            result.Add(new List<int>());
            result[0].Add(1);

            for (int i = 1; i < numRows; i++)
            {
                result.Add(calculateNextLine((List<int>)result[i - 1]));
            }                

            return result;
        }

        /// <summary>
        /// Calculates the next line of pascal's triangle based on the line given.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static List<int> calculateNextLine(List<int> list)
        {
            var result = new List<int>();
            result.Add(list[0]);

            for (int i = 0; i <= list.Count - 2; i++)
            {
                result.Add(list[i] + list[i + 1]);
            }

            result.Add(list[list.Count - 1]);
            return result;
        }
    }
}
