using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class SquareRoot
    {
        public void Test()
        {
            /*
             * Given a non-negative integer x, 
             * return the square root of x rounded down to the nearest integer. 
             * The returned integer should be non-negative as well
             */
            int result = MySqrt(9);
        }

        public int MySqrt(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            int left = 1;
            int right = x;
            int sqrt = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid <= x / mid)
                {
                    sqrt = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return sqrt;
        }
    }
}
