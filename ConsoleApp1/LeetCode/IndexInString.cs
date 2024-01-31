using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class IndexInString
    {
        public void Test()
        {

            //var result = StrStr("sadbutsad", "sad");
            //var result = StrStr("hello", "ll");
            var result = StrStr("a", "a");


        }

        public int StrStr(string haystack, string needle)
        {
            /*
             * sadbutsad
             * sad
             * 0 => 
             */

            for (int i = 0; i < haystack.Length; i++)
            {
                var needleEnd = haystack.Length - needle.Length;

                if (i <= needleEnd)
                {
                    var substr = haystack.Substring(i, needle.Length);

                    if (substr.Equals(needle))
                        return i;
                }
            }
            return -1;
        }
    }
}
