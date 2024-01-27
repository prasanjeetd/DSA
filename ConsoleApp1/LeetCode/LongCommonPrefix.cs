using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class LongCommonPrefix
    {
        public void Test()
        {

            var param = new string[] { "flower", "flow", "flight" };
            //var param = new string[] { "", "b"};
            //var param = new string[] { "a", "ac" };

            var result = Get1(param);
            Console.WriteLine(result);

            /*
             * 
             * flower
             * flow
             *  f = y
             *  l = y
             *  o = y
             *  w = n
             * flight
             *  f = y
             *  l = y
             *  i = n
             * 
             */

        }

        public string Get(string[] strs)
        {

            var first = strs[0];

            if (strs.Length == 1)
            {
                return first;
            }

            if (string.IsNullOrEmpty(first))
                return "";

            int cnt = 0;
            for (int i = 1; i < strs.Length; i++)
            {
                var next = strs[i];

                if (string.IsNullOrEmpty(next))
                    return "";

                int same = 0;
                for (int j = 0; j < next.Length && j < first.Length; j++)
                {
                    if (first[j] == next[j])
                        same++;
                    else
                        break;
                }

                if (same == 0)
                {
                    cnt = 0;
                    break;
                }

                if (cnt == 0 || same < cnt)
                {
                    cnt = same;
                }
            }

            if (cnt == 0)
                return "";

            return first.Substring(0, cnt);
        }

        public string Get1(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                // Step 1: Check if the current prefix is a prefix of the current string
                while (strs[i].IndexOf(prefix) != 0)
                {
                    // Step 2: If the current prefix is not a prefix of the current string, remove the last character from the prefix
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // Step 3: If the prefix becomes empty, there is no common prefix, so return an empty string
                    if (prefix.Length == 0)
                        return "";
                }
            }

            // Step 4: Return the final common prefix
            return prefix;
        }

    }
}
