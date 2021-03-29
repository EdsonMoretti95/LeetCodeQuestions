using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    ///     Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    ///     An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.You may assume all four edges of the grid are all surrounded by water.
    ///     Examples:
    ///     Example 1:
    ///     
    ///     Input: grid = [
    ///       ["1","1","1","1","0"],
    ///       ["1","1","0","1","0"],
    ///       ["1","1","0","0","0"],
    ///       ["0","0","0","0","0"]
    ///     ]
    ///     Output: 1
    ///     Example 2:
    ///     
    ///     Input: grid = [
    ///       ["1","1","0","0","0"],
    ///       ["1","1","0","0","0"],
    ///       ["0","0","1","0","0"],
    ///       ["0","0","0","1","1"]
    ///     ]
    ///     Output: 3
    ///      
    ///     
    ///     Constraints:
    ///     
    ///     m == grid.length
    ///     n == grid[i].length
    ///     1 <= m, n <= 300
    ///     grid[i][j] is '0' or '1'.
    /// </summary>
    public class NumberOfIslands
    {
        public static void Solve()
        {
            char[,] test = new char[,] { {'1', '1', '1', '1', '0'},
                                         {'1', '1', '0', '1', '1'},
                                         {'1', '0', '1', '0', '1'},
                                         {'0', '1', '1', '1', '0'},
            };

            Console.WriteLine("Input Array:");

            for (int i = 0; i < test.GetLength(0); i++)
            {
                var s = "";
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    s += $",{test[i, j]}";
                }
                Console.WriteLine(s.Remove(0, 1));
            }

            Console.WriteLine($"Result: {NumIslands(test)}");
        }

        public static int NumIslands(char[,] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == '1')
                    {
                        count++;
                        RemoveIsland(grid, i, j);
                    }  
                }
            }

            return count;

            // go through the array from the first char to the left
            // if the char is 1, check if left is 2 

        }

        /// <summary>
        /// This Method uses an algorithm called Depth-First Search to find all of the "nodes" that are part of the island we give.
        /// Then it turns all '1' that make up the island into 0 essentially deleting the island from the grid.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private static void RemoveIsland(char[,] grid, int i, int j)
        {
            // check out of bounds and if given position is 0
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i,j] == '0')
            {
                return;
            }

            grid[i, j] = '0';
            RemoveIsland(grid, i + 1, j);
            RemoveIsland(grid, i, j + 1);
            RemoveIsland(grid, i - 1, j);
            RemoveIsland(grid, i, j - 1);
        }
    }
}
