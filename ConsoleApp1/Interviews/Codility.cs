using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class Codility
    {
        public int Solution(int[] A)
        {
            int n = A.Length;
            bool[] present = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] <= n)
                {
                    present[A[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!present[i])
                {
                    return i;
                }
            }

            return n + 1;
        }

        public int SolutionB(int[] A)
        {
            int n = A.Length;
            Dictionary<int, bool> present = new Dictionary<int, bool>();

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] <= n)
                {
                    present[A[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!present.ContainsKey(i))
                {
                    return i;
                }
            }

            return n + 1;
        }
    }
}
