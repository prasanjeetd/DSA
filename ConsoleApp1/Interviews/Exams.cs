using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class Exams
    {
        public void Test()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            var outPut = new int[arr.Length];
            int move = 2;


            // 4 1 2 3


            for (int i = 0; i < arr.Length; i++)
            {
                var next = i + move >= outPut.Length ? i + move - outPut.Length : i + move;

                outPut[i] = arr[next];
            }

            // 1 2 3 4
            // 4 3 2 1
            // 3 4 1 2


            for (int i = 0; i < arr.Length; i++)
            {
                var next = i + move >= outPut.Length ? i + move - outPut.Length : i + move;

            }
        }
    }

    public class L
    {

        public int square(int num)
        {
            return num * num;
        }

        Func<int, int> func = (int x) => { return x * x; };

        /*
         * 
         * Given an integer array sorted in non-decreasing order remove the duplicates.
         * 
         * 
         * */

        public int[] Remove(int[] num)
        {

            var a = num.Distinct().ToArray();

            var map = new Dictionary<int, int>();

            return a;
        }


    }
}
