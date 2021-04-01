using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
    /// </summary>
    class ReverseInteger
    {
        public static void Solve()
        {
            var num = 1534236469;

            Console.WriteLine(Reverse(num));
        }

        public static int Reverse(int num)
        {                        
            long newNum = 0;
            while (num != 0)
            {
                newNum *= 10;
                newNum += num % 10;
                num -= num % 10;
                if (num != 0) num /= 10;
            }

            if (newNum < int.MinValue || newNum > int.MaxValue) return 0;

            return (int)newNum;
        }
    }
}
