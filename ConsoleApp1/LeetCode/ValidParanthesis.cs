using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LeetCode
{
    public class ValidParanthesis
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var top = stack.Pop();

                    if (s[i] == ')' && top != '(')
                    {
                        return false;
                    }
                    else if (s[i] == '}' && top != '{')
                    {
                        return false;
                    }
                    else if (s[i] == ']' && top != '[')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }


        public bool IsValid2(string s)
        {
            var map = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var top = stack.Pop();

                    if (map[top] != c)
                    {
                        return false;
                    }
                }

            }


            return stack.Count == 0;

        }
    }
}
