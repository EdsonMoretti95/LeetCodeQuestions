using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given the head of a singly linked list, return true if it is a palindrome.
    /// 
    /// Example 1:
    /// Input: head = [1,2,2,1]
    /// Output: true
    /// 
    /// Example 2:
    /// Input: head = [1,2]
    /// Output: false
    /// </summary>
    class PalindromeLinkedList
    {
        public static void Solve()
        {
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(2);
            list.next.next.next = new ListNode(1);

            Console.WriteLine($"Is Palindrome: {IsPalindrome(list)}");
        }

        /// <summary>
        /// To check if a linked list is palindrome we add the values to a new list where we have an index and then later 
        /// we loop with pointers starting from the begining and from the end of the list checking if the elements are equal
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsPalindrome(ListNode head)
        {
            List<int> values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            int i = 0;
            int j = values.Count - 1;

            while (j > i)
            {
                if (values[i] != values[j]) return false;
                i++;
                j--;
            }

            return true;
        }
    }


}
