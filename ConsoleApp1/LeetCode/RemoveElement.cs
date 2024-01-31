using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class RemoveElementAlgo
    {
        public void Test()
        {

            var nums = new int[] { 3, 2, 2, 3 };
            var result = RemoveElement(nums, 3);
        }


        public int RemoveElement(int[] nums, int val)
        {
            if(nums.Length == 0)
                return 0;

            /*
             * 
             * 3 2 2 3
             * 3
             * 
             * 3 == 3 => yes
             * 
             * index= 0 : 
             * 3
             * 
             */

            int index = 0;

            for(int i = 0;i< nums.Length;i++)
            {
                var digit = nums[i];

                if(digit != val)
                {
                    nums[index] = digit;
                    index++;
                }
            }
            return index;
        }
    }
}
