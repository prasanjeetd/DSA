using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class Palindrome
    {

        public bool IsPalindrome(int x)
        {
            string num = x.ToString();

            for(int i=0;i< num.Length/2; i++)
            {
                int a = i;
                int b = num.Length - 1 - i;

                if (num[a] != num[b])
                    return false;   

            }

            return true;
        }

        public bool IsPalindromeWithoutString(int x)
        {
            //if (x < 0)
            //    return false;

            //int num = x;
            //int rev = 0;

            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    rev = rev * 10 + digit;
            //    num = num / 10;
            //}

            //return rev == x;

            if( x< 0)
                return false;

            int num = x;
            int rev = 0;

            while(num > 0)
            {
                rev= rev *10 + num % 10;
                num = num / 10;
            }


            return rev == x;
        }
    }
}
