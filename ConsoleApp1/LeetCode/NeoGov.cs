using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class NeoGov
    {

        public string LongestPalindrome(string s)
        {
            // Step 1: Create a dictionary to store the frequency of each character
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            // Step 2: Iterate over the string, counting the frequency of each character
            foreach (char c in s)
            {
                if (!charCounts.ContainsKey(c))
                {
                    charCounts[c] = 0;
                }
                charCounts[c]++;
            }

            // Step 3: Initialize variables to store the length of the longest palindrome and the middle character
            int length = 0;
            char middle = ' ';

            // Step 4: Iterate over the dictionary
            foreach (KeyValuePair<char, int> pair in charCounts)
            {
                // Step 5: If the frequency is even, add it to the length
                if (pair.Value % 2 == 0)
                {
                    length += pair.Value;
                }
                // Step 6: If the frequency is odd and greater than the frequency of the current middle character, update the middle character
                else if (pair.Value > (middle == ' ' ? 0 : charCounts[middle]))
                {
                    middle = pair.Key;
                }
            }

            // Step 7: If there is a middle character, add it to the length and insert it into the middle of the palindrome
            if (middle != ' ')
            {
                length++;
                return new string(' ', length / 2) + middle + new string(' ', length / 2);
            }
            // Step 8: If there is no middle character, just return the palindrome
            else
            {
                return new string(' ', length);
            }
        }

    }
}
