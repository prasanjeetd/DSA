using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class AddBinaryAlgo
    {
        public void Test()
        {

            /*
             * 
             * Given two binary strings a and b, 
             * return their sum as a binary string.
             * 
             */

            //var result = AddBinary1("1011", "1101");
            var result = AddBinary1("10011", "10111");

        }

        public string AddBinary1(string a, string b)
        {
            int i = a.Length - 1; // initialize the index for string a
            int j = b.Length - 1; // initialize the index for string b

            int carry = 0; // initialize the carry variable to 0

            string sb = ""; // initialize an empty string to store the result

            while (i >= 0 || j >= 0 || carry > 0) // loop until both strings are processed and there is no carry left
            {
                int sum = carry; // initialize the sum with the carry value

                if (i >= 0) // if there are still characters in string a
                {
                    sum += a[i] - '0'; // add the current character of string a to the sum
                    i--; // move to the next character in string a
                }

                if (j >= 0) // if there are still characters in string b
                {
                    sum += b[j] - '0'; // add the current character of string b to the sum
                    j--; // move to the next character in string b
                }

                var reminder = sum % 2; // calculate the remainder of the sum divided by 2
                sb = reminder + sb; // append the remainder to the result string
                carry = sum / 2; // calculate the carry by dividing the sum by 2
            }

            return sb; // return the final result string
        }

        public string AddBinary(string a, string b)
        {

            /* 
             * 1011
             * 1101
             * 
             * right to left
             * 
             * looping two array
             * 
             * 1 + 1 =10
             * reminder =0
             * carry = 1
             * 
             * 1 +0 + carry: 1 = 10
             * reminder =0
             * carry = 1
             * 
             * 1+1 =10 : binary
             * 1+1 = 2 : numeric
             * 
             * 0+0 =0
             * 0+1 =1
             * 
             * 1+ =3
             * 
             */

            var i = a.Length - 1;
            var j = b.Length - 1;
            int carry = 0;

            string result = "";

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry;

                if (i >= 0)
                {
                    sum = sum + a[i] - '0';
                    i--;
                }

                if (j >= 0)
                {
                    sum = sum + b[j] - '0';
                    j--;
                }


                int reminder = sum % 2;
                carry = sum / 2;

                result = reminder + result;
            }

            return result;
        }
    }
}
