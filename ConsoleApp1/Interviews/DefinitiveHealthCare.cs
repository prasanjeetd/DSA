using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class DefinitiveHealthCare
    {
        public static int[] MoveElementToEnd(int[] array, int toMove)
        {
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                if (array[j] == toMove)
                {
                    j--;
                }
                else if (array[i] == toMove)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return array;
        }
    }
}
