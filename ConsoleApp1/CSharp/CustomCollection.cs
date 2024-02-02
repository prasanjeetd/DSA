using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp
{
    public class CustomCollection : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            foreach (var i in nums)
            {
                yield return i;
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class CollectionTest
    {
        public void Test()
        {

            var customCollection = new CustomCollection();

            foreach (var i in customCollection)
            {

            }
        }
    }
}
