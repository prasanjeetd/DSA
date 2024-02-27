using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings
{
    public class SemaphoreLock
    {
        private Semaphore _semaphore = new Semaphore(2, 2);

        public void Test()
        {

            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }

            Thread.Sleep(1000);
        }


        public void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} waiting...");
            _semaphore.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing...");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing completed...");
            _semaphore.Release();
        }

    }
}
