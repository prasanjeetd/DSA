using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class RemoveDuplicatesFromArray
    {
        public void Test()
        {
            //var nums = new int[] { 1, 2, 3, 3, 4, 5, 5, 5, 8 };
            //var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var nums = new int[] { 1, 1, 2 };

            int unique = RemoveDuplicates1(nums);

            Console.WriteLine(unique);
        }

        public int RemoveDuplicates(int[] nums)
        {
            /*
             * nums =[ 1, 2 ,3 ,3 ,4 ,5 ,5 ,5 ,8]
             * 
             * unique = 0
             * 
             * index = 0
             * digit = 1
             * next = 1
             * nextDigit =2
             * 
             * 1 != 2 = no
             * unique =1
             * 
             * index = 1
             * digit = 2
             * next =3
             * nextDigit =3
             * 2!= 3 = no
             * unique =2
             * 
             * index = 2
             * digit = 3
             * next = 3
             * nextDigit = 3
             * 3==3 = yes
             * 
             * index = 3
             * digit = 3
             * next =4
             * nextDigit = 4
             * 3 != 4 = no
             * 
             * unique = 3
             * 
             * 
             * 
             * 
             */

            int unique = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int digit = nums[i];
                int next = nums[i + 1];

                if (digit != next)
                {
                    nums[unique] = digit;
                    unique++;
                }

                if (i == nums.Length - 2)
                {

                    unique++;
                }

            }

            return unique;
        }

        public int RemoveDuplicates1(int[] nums)
        {
            /*
             * 
             * 
             * 
             * 
             * 
             */



            if (nums.Length == 0)
            {
                return 0;
            }

            int unique = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[unique] = nums[i];
                    unique++;
                }
            }

            return unique;
        }

    }
}
