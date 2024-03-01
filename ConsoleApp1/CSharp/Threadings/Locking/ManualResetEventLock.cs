using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings.Locking
{
    public class ManualResetEventLock
    {
        ManualResetEvent _mre = new ManualResetEvent(false);

        public void Test()
        {

            new Thread(Write).Start();

            for (int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }
        }

        public void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing...");
            _mre.Reset();
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing completed...");
            _mre.Set();
        }

        public void Read()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} waiting...");
            _mre.WaitOne();
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} reading...");
        }
    }
}
