using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    /// 
    /// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    /// 
    /// Roman numerals are usually written largest to smallest from left to right.
    /// However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. 
    /// The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
    /// 
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// "DCXXI"
    /// I can be placed before V (5) and X(10) to make 4 and 9. 
    /// X can be placed before L(50) and C(100) to make 40 and 90. 
    /// C can be placed before D(500) and M(1000) to make 400 and 900.
    /// 
    /// Given a roman numeral, convert it to an integer.
    /// 
    /// Example 1:
    /// Input: s = "III"
    /// Output: 3
    /// </summary>
    class RomanToDecimal
    {
        public static void Solve()
        {
            string roman = "IV";

            Console.WriteLine(RomanToInt(roman));
        }

        public static int RomanToInt(string s)
        {
            int curr = 0;

            for (int i = 0; i < s.Length; i++)
            {
                
                switch (s[i])
                {
                    case 'I':
                        curr+= 1;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == 'V')
                            {
                                curr+= 3;
                                i++;
                            }
                            else if (s[i + 1] == 'X')
                            {
                                curr+= 8;
                                i++;
                            }
                        }
                        break;

                    case 'V':
                        curr+= 5;
                        break;

                    case 'X':
                        curr+= 10;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == 'L')
                            {
                                curr+= 30;
                                i++;
                            }
                            else if (s[i + 1] == 'C')
                            { 
                                curr+= 80; 
                                i++; 
                            }
                        }
                        break;

                    case 'L':
                        curr+= 50;
                        break;

                    case 'C':
                        curr+= 100;
                        if (i + 1 < s.Length)
                        {
                            if (s[i + 1] == 'D')
                            {
                                curr+= 300;
                                i++;
                            }
                            else if (s[i + 1] == 'M') 
                            { 
                                curr+= 800; 
                                i++;
                            };
                        }
                        break;

                    case 'D':
                        curr+= 500;
                        break;

                    case 'M':
                        curr+= 1000;
                        break;

                    default:
                        break;
                }
            }

            return curr;
        }
    }
}
