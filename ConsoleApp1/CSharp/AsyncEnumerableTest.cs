using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp
{
    public class AsyncEnumerableTest
    {
        public async IAsyncEnumerable<int> GetAsync()
        {
            for(int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public async Task Test() { 
        
            await foreach( var i in GetAsync())
            {
                Console.WriteLine(i);
            }

        }
    }
}
