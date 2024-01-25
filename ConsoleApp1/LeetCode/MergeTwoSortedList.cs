using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
       
    }

    public class MergeTwoSortedList
    {

        public void Test()
        {
            var list1 = new ListNode(1);
            var l17 = new ListNode(7);
            var l15 = new ListNode(5);
            var l13 = new ListNode(3);

            l15.Next = l17;
            l13.Next = l15;
            list1.Next = l13;

            var list2 = new ListNode(1);
            var l28 = new ListNode(8);
            var l27 = new ListNode(7);
            var l24 = new ListNode(4);
            var l22 = new ListNode(2);

            l27.Next = l28;
            l24.Next = l27;
            l22.Next = l24;
            list2.Next = l22;


            this.Merge(list1, list2);

        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Check if either list is null
            if (list1 == null)
            {
                return list2; // If list1 is null, return list2
            }
            if (list2 == null)
            {
                return list1; // If list2 is null, return list1
            }

            // Create a dummy node to serve as the head of the merged list
            ListNode dummy = new ListNode(0);
            ListNode current = dummy; // Create a current node to keep track of the current position in the merged list

            // Iterate through both lists until one of them reaches the end
            while (list1 != null && list2 != null)
            {
                // Compare the values of the current nodes in both lists
                if (list1.Val < list2.Val)
                {
                    // If the value in list1 is smaller, add it to the merged list and move to the next node in list1
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    // If the value in list2 is smaller or equal, add it to the merged list and move to the next node in list2
                    current.Next = list2;
                    list2 = list2.Next;
                }
                current = current.Next; // Move the current node to the next position in the merged list
            }

            // Add the remaining nodes from list1 or list2 to the merged list
            if (list1 != null)
            {
                current.Next = list1;
            }
            if (list2 != null)
            {
                current.Next = list2;
            }

            return dummy.Next; // Return the head of the merged list (excluding the dummy node)
        }

        public ListNode Merge(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;

            if (list2 == null)
            {
                return list1;
            }

            var tempNode = new ListNode(0);
            var current = tempNode;

            while (list1 != null && list2 != null)
            {
                if (list1.Val < list2.Val)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }

                current = current.Next;
            }

            if (list1 != null)
            {
                current.Next = list1;
            }
            else if (list2 != null)
            {
                current.Next = list2;
            }

            return tempNode.Next;
        }
    }
}
