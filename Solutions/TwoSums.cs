using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// 
    /// Example 1:
    /// Input: nums = [2,7,11,15], target = 9
    /// Output: [0,1]
    /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// 
    /// </summary>
    class TwoSums
    {
        public static void Solve()
        {
            int[] nums = { 2, 7, 11, 15 };

            var res = TwoSum(nums, 9);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();

            if (nums == null || nums.Length == 0) return new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (values.ContainsKey(target - nums[i]))
                {
                    return new int[2] { i, values[target - nums[i]] };
                }
                else if (!values.ContainsKey(target - nums[i]))
                {
                    values.Add(nums[i], i);
                }
            }

            return new int[2];
        }
    }
}
