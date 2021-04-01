using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Implement a basic calculator to evaluate a simple expression string.
    /// The expression string may contain open(and closing parentheses), the plus+or minus sign-, non-negative integers and empty spaces.
    /// The expression string contains only non-negative integers,+,-,*,/operators , open(and closing parentheses)and empty spaces.
    /// The integer division should truncate toward zero.
    /// </summary>
    class BasicCalculatorII
    {
        public static void Solve()
        {
            var s = "3+2*2/2";

            Console.WriteLine($"Result: {Calculate2(s)}");
        }

        public static int Calculate(string s)
        {
            var st = new Stack<int>();

            if (s.Length == 0) return 0;
            
            int sign = 1;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (Char.IsDigit(c))
                {
                    int currentNumber = 0;
                    // read the whole number
                    while ((i < s.Length) && Char.IsDigit(s[i]))
                    {
                        // a char int value is the ASCII number so we put - '0' to get the value of the number so 5(53) - 0(48) = 5.
                        currentNumber = (currentNumber * 10) + (s[i] - '0');
                        i++;
                    }
                    i--;

                    st.Push(currentNumber * sign);
                }else if (c == '+')
                {
                    sign = 1;
                }else if (c == '-')
                {
                    sign = -1;
                }else if (c == '*' || c=='/')
                {
                    i++;
                    int currentNumber = 0;
                    while ((i < s.Length) && (Char.IsDigit(s[i]) || s[i] == ' ') )
                    {
                        if (s[i] != ' ')
                        {
                            currentNumber = (currentNumber * 10) + (s[i] - '0');
                        }                        
                        i++;
                    }
                    i--;

                    currentNumber = c == '*' ? st.Pop() * currentNumber : st.Pop() / currentNumber;
                    st.Push(currentNumber);
                }
            }
            return sumStack(st);
        }

        public static int sumStack(Stack<int> st)
        {
            int sum = 0;
            while (st.Count > 0)
            {
                sum += st.Pop();
            }

            return sum;
        }

        public static int Calculate2(string s)
        {
            if (s == null || s.Length == 0) return 0;

            var stack = new Stack<int>();
            char preSign = '+';
            int num = 0; // to compose the number from string, 12, or 4, maybe more than two digits
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (Char.IsDigit(c))
                {
                    num = num * 10 + c - '0';
                } else if (c != ' ' || i == s.Length - 1)
                {
                    pushNumberOp(stack, num, preSign);                    
                    num = 0;
                    preSign = c;
                }
            }
            pushNumberOp(stack, num, preSign);
            return sumStack(stack);
        }

        public static void pushNumberOp(Stack<int> st, int num, char op)
        {
            switch (op)
            {
                case '+':
                    st.Push(num);
                    break;
                case '-':
                    st.Push(-num);
                    break;
                case '*':
                    st.Push(st.Pop() * num);
                    break;
                case '/':
                    st.Push(st.Pop() / num);
                    break;
            }
        }
    }
}
