using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class RomanToInt
    {
        readonly Dictionary<char, int> map = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int Convert(string s)
        {
            var number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = map[s[i]];


                int nextCount = i + 1;

                if (nextCount < s.Length)
                {
                    int next = map[s[i + 1]];

                    if (current < next)
                    {
                        number = number + (next - current);
                        i++;
                    }
                    else
                    {
                        number += current;
                    }
                }
                else
                {
                    number += current;
                }
            }
            return number;
        }
    }
}
