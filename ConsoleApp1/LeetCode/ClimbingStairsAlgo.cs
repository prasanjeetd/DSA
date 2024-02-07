using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class ClimbingStairsAlgo
    {
        public void Test()
        {
            /*
             * You are climbing a staircase. It takes n steps to reach the top.
             * Each time you can either climb 1 or 2 steps. 
             * In how many distinct ways can you climb to the top?
             */

            int n = 3;
            int result = ClimbStairs(n);
            Console.WriteLine("Number of distinct ways to climb to the top: " + result);
        }

        public int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int two = 2;
            int one = 1;

            for (int i = 3; i <= n; i++)
            {
                int current = two + one;
                one = two;
                two = current;
            }

            return two;
        }

       
    }
}
