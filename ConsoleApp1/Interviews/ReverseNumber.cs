using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    internal class ReverseNumber
    {
        public int reverse(int num)
        {
            int rev = num;

            int a = num / 10;
            int b = num % 10;

            do
            {
                Console.WriteLine($"num: {num} ");
                rev = num % 10;
                Console.WriteLine($" rev: {rev}");
                num = num / 10;


            } while (num > 0);




            return rev;
        }
    }
}
