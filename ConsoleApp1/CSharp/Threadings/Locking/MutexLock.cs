using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings.Locking
{
    public class MutexLock
    {
        private Mutex _mutex = new Mutex();

        public void Test()
        {

            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }

            Thread.Sleep(1000);
            //_mutex.ReleaseMutex();  // Will throw error
        }

        public void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} waiting...");
            _mutex.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing...");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing completed...");
            _mutex.ReleaseMutex();
        }
    }
}
