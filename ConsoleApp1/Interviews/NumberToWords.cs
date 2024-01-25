using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    internal class NumberToWords
    {
        public void printDigitToWord(int digit)
        {
            var digits = new Dictionary<int, string>
    {
        { 0, "Zero" },
        { 1, "One" },
        { 2, "Two" },
        {3,"Three" },
        {4,"Four" },
        { 11, "Eleven" },
        { 20, "Twenty" },
        {30, "Thirty" },
        {40, "Fourty" }
    };

            var series = new Dictionary<int, string>
    {
        {1, "Hundred" },
        {2, "Thousand" }

    };

            int digitCount = 0;

            int nums = digit;
            int reverseDigit = 0;

            while (nums > 0)
            {
                reverseDigit = reverseDigit * 10 + nums % 10;
                nums = nums / 10;
                digitCount++;
            }

            string words = string.Empty;

            int process = digitCount;

            while (process > 2)
            {
                int nth = process - 2;
                int digitValue = reverseDigit % 10;
                reverseDigit = reverseDigit / 10;

                words += " " + digits[digitValue] + " " + series[nth];
                process--;
            }

            if (process <= 2)
            {
                if (digits.ContainsKey(reverseDigit))
                {
                    Console.WriteLine(digits[reverseDigit]);
                }
                else
                {
                    int firstDigit = reverseDigit / 10 * 10;
                    int secondDigit = reverseDigit % 10;

                    words += " " + digits[firstDigit] + " " + digits[secondDigit];

                }
            }

            Console.WriteLine(words);

        }
    }
}
