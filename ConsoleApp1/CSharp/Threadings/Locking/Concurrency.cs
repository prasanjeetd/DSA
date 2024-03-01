using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings.Locking
{
    public class Concurrency
    {
        private ConcurrentBag<int> _bag = new();

        public void Test()
        {
            Parallel.For(0, 1000, i =>
            {
                _bag.Add(i);
            });


            var result = new ArrayList();
            if (_bag.TryTake(out int number))
            {
                result.Add(number);
            }
        }


    }
}
