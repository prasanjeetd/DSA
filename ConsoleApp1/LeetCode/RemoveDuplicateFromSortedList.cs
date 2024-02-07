using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class RemoveDuplicateFromSortedList
    {

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


        public void Test()
        {

            /*
             * 
             * Given the head of a sorted linked list, 
             * delete all duplicates such that each element appears only once.
             * Return the linked list sorted as well.
             */

            //var ll = new ListNode(1);
            //ll.next = new ListNode(1);
            //ll.next.next = new ListNode(2);
            //ll.next.next.next = new ListNode(3);
            //ll.next.next.next.next = new ListNode(3);
            //ll.next.next.next.next.next = new ListNode(3);

            var ll = new ListNode(1);
            ll.next = new ListNode(1);
            ll.next.next = new ListNode(2);

            var newList = DeleteDuplicates(ll);

        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var current = head;
            var next = current.next;

            while (next != null)
            {

                if (current.val != next.val)
                {
                    current.next = next;
                    current = current.next;
                }

                next = next.next;

            }

            if (current.next != null && current.val == current.next.val)
            {
                current.next = null;
            }

            return head;
        }
    }
}
