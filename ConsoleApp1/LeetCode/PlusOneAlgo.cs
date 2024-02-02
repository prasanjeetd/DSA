using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class PlusOneAlgo
    {
        public void Test()
        {

            /*
             * 
             * You are given a large integer represented as an integer array digits, 
             * where each digits[i] is the ith digit of the integer. 
             * The digits are ordered from most significant to least significant in left-to-right order. 
             * The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
             */


            //var result = PlusOne(new int[] { 1, 2, 3 });
            //var result = PlusOne(new int[] { 9 });
            //var result = PlusOne(new int[] { 1, 3, 9 });
            //var result = PlusOne(new int[] { 8, 9, 9 });
            var result = PlusOne(new int[] {  9, 9 });



        }

        public int[] PlusOne1(int[] digits)
        {

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            var sumStr = sum.ToString();

            if (sumStr.Length > digits.Length)
            {
                var output = new int[digits.Length + 1];

                for (int i = 0; i < sumStr.Length; i++)
                {
                    output[i] = sumStr[i] - '0';
                }

                return output;
            }
            else
            {
                digits[digits.Length - 1] = sum;
                return digits;
            }
        }


        public int[] PlusOne2(int[] digits)
        {
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                // Step 1: Check if the current digit is less than 9
                if (digits[i] < 9)
                {
                    // Step 2: If the current digit is less than 9, increment it by one
                    digits[i]++;
                    return digits;
                }
                // Step 3: If the current digit is 9, set it to 0 and continue to the next digit
                digits[i] = 0;
            }

            // Step 4: If all digits are 9, create a new array with an additional digit and set the first digit to 1
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }

        public int[] PlusOne(int[] digits)
        {

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            var output = new int[digits.Length + 1];
            output[0] = 1;

            return output;
        }
    }
}
