using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class SearchInsertPosition
    {
        public void Test()
        {

            /*
             * 
             * Given a sorted array of distinct integers and a target value, return the index if the target is found. 
             * If not, return the index where it would be if it were inserted in order.
             * 
             */

            var result = SearchInsert(new int[] { 1, 3, 5, 6 }, 5);

        }

        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var digit = nums[i];

                if (digit >= target)
                    return i;

            }

            return nums.Length;
        }
    }
}
