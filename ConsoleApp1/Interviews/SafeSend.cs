using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class SafeSend
    {
        private string _message;
        public string Name { get; set; } = "Delegate Message";

        public SafeSend()
        {
            _message = "Initial message";
        }

        public string GetMessage()
        {
            return Name + _message;
        }

        /*
 *  boxes =h:0.5 , 1 ,1.5,2,2.5,3
 *  
 *  room =>
 *  
 *  h
 *  
 *  3
 *  2.5
 *  
 *  /
 *  
 *  /
 *  
 *  15 = 3 + 2.5 + 2 +
 *  
 *  15 = 15 -3 = 12
 *  12 = 
 *  
 *  
 */

        double[] getBoxes(double roomHeight)
        {
            var heighBoxes = new double[] { 0.5, 1, 1.5, 2, 2.5, 3 };


            int j = heighBoxes.Length - 1;

            var boxes = new List<double>();

            var next = roomHeight;

            while (j >= 0 || next == roomHeight)
            {
                if (heighBoxes[j] > next)
                {
                    j--;
                    continue;
                }

                next = next - heighBoxes[j];
                boxes.Add(heighBoxes[j]);

                j--;

            }

            return boxes.ToArray();

        }
    }

    public class SafeSendClient
    {
        private delegate string GetMessage();

        public void Test()
        {
            var delObj = new SafeSend();
            GetMessage callBack = delObj.GetMessage;

            Console.WriteLine(callBack());
        }
    }

    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            int start = 0;
            int end = input.Length - 1;

            while (start < end)
            {
                char startChar = char.ToLower(input[start]);
                char endChar = char.ToLower(input[end]);

                if (startChar == ' ')
                {
                    start++;
                    continue;
                }

                if (endChar == ' ')
                {
                    end--;
                    continue;
                }

                if (startChar != endChar)
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }


}
