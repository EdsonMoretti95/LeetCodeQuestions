using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// </summary>
    class ReverseLinkedList
    {
        public static void Solve()
        {
            ListNode numbers = new ListNode(1);

            ListNode node = numbers;
            for (int i = 1; i < 5; i++)
            {
                node.next = new ListNode(i + 1);
                node = node.next;
            }

            numbers = ReverseListRecursion(numbers);
            //numbers = ReverseListLoop(numbers);


            while (numbers != null)
            {
                Console.WriteLine(numbers.val.ToString());
                numbers = numbers.next;
            }

        }

        private static ListNode ReverseListLoop(ListNode head)
        {
            ListNode previousNode = null;

            while(head != null)
            {
                ListNode nextNode = head.next;                
                head.next = previousNode;
                previousNode = head;
                head = nextNode;
            }

            return previousNode;
        }

        public static ListNode ReverseListRecursion(ListNode head)
        {
            if (head == null) return head;
            
            ListNode nextNode = head.next;
            if (nextNode == null) return head;

            ListNode reversed = ReverseListRecursion(head.next);

            nextNode.next = head;
            head.next = null;

            return reversed;            
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
