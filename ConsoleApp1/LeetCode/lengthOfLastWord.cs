using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class lengthOfLastWord
    {
        public void Test() {

            /*
             * Given a string s consisting of words and spaces, return the length of the last word in the string.

             * 
             */

            var result = LengthOfLastWord("Hello World");
        }

        public int LengthOfLastWord(string s)
        {
            var words= s.Split(' ').Where( x=> !String.IsNullOrEmpty(x) ).ToArray();

            return words[words.Length-1].Length;
        }
    }
}
