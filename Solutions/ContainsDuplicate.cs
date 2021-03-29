using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    /// 
    /// Example 1:
    /// Input: nums = [1,2,3,1]
    /// Output: true
    /// 
    /// Example 2:
    /// Input: nums = [1,2,3,4]
    /// Output: false
    /// </summary>
    class ContainsDuplicate
    {
        public static void Solve()
        {
            int[] numbers = new int[] { 1, 5, 3, 6 };

            Console.WriteLine($"Contains Duplicate: {CheckDuplicate(numbers).ToString()}");
        }

        /// <summary>
        /// Check if the array contains a duplice by using an auxiliary HashSet.
        /// When adding the new number into the HashSet check if the number is already in the HashSet, if it is return true.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CheckDuplicate(int[] nums)
        {
            HashSet<int> n = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (n.Contains(nums[i])) return true;
                n.Add(nums[i]);
            }

            return false;
        }

    }
}
