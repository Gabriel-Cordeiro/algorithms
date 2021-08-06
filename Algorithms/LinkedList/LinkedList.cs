using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public static class LinkedListMethods
    {
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || head.Next == null || left == 0 || left == right)
                return head;

            ListNode current = head;

            if (head.Next.Next != null)
            {
                while (current != null)
                {
                    if (current.Val == left)
                    {
                        current.Val = right;
                        current = current.Next;
                    }
                    else if (current.Val == right)
                    {
                        current.Val = left;
                        current = current.Next;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
                return head;
            }
            else
            {
                Console.WriteLine("caiu");
                var firstValue = head.Val;
                head.Val = head.Next.Val;
                head.Next.Val = firstValue;
                return head;
            }
        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode current = head;

            while (current != null && current.Next != null)
            {
                if (current.Val == current.Next.Val)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }

            return head;
        }
        public static ListNode MergeTwoListsRecursive(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            var nextl1 = l1.Next;
            var nextl2 = l2.Next;


            if (l1.Val < l2.Val)
            {
                l1.Next = MergeTwoListsRecursive(nextl1, l2);
                return l1;
            }
            else
            {
                l2.Next = MergeTwoListsRecursive(l1, nextl2);
                return l2;
            }
        }
    }
}
