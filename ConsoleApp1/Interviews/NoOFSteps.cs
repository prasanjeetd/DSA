using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class NoOFSteps
    {

        public int Solution(string s)
        {


            return 0;
        }

        public int SolutionB(string s)
        {

            int v = Convert.ToInt32(s, 2);
            int steps = 0;

            while (v > 0)
            {
                if (v % 2 == 0)
                {
                    v /= 2;
                }
                else
                {
                    v -= 1;
                }

                steps++;
            }

            return steps;
        }


        public int SolutionC(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return 0;
            }

            int v = Convert.ToInt32(S, 2);
            int steps = 0;

            while (v > 0)
            {
                if ((v & 1) == 0)
                {
                    v >>= 1;
                }
                else
                {
                    v -= 1;
                }

                steps++;
            }

            return steps;
        }

        public int SolutionD(string s)
        {
            int steps = 0;
            int i = s.Length - 1;

            while (i >= 0)
            {
                if (s[i] == '0')
                {
                    steps++; // shift right
                    i--;
                }
                else
                {
                    while (i >= 0 && s[i] == '1')
                    {
                        steps++; // change '1' to '0'
                        i--;
                    }
                    steps++; // shift right
                }
            }

            return steps;
        }
        public int MaxSum(int[] cards)
        {
            Array.Sort(cards);
            int sum = 0;

            for (int i = 0; i < cards.Length; i += 2)
            {
                sum += cards[i];
            }

            return sum;
        }
        public int CountValidWords(string s, string[] k)
        {
            HashSet<char> set = new HashSet<char>(s);
            int validWords = 0;

            foreach (string word in k)
            {
                bool isValid = true;
                foreach (char c in word)
                {
                    if (!set.Contains(c))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    validWords++;
                }
            }

            return validWords;
        }

    }


}
