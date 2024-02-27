using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings
{
    public class ThreadLock
    {
        private Object _locker = new Object();

        public void Test()
        {

            MonitorLock monitorLock = new();

            for (int i = 0; i < 5; i++)
            {
                //new Thread(DoWork).Start();
                new Thread(monitorLock.DoWork).Start();
            }

            Console.WriteLine("Thread Completed");
        }

        public void DoWork()
        {
            lock (_locker)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} reading completed...");
            }

        }
    }

    public class MonitorLock
    {
        private Object _locker = new Object();

        public void DoWork()
        {
            try
            {

                Monitor.Enter(_locker);

                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);

                throw new Exception("Thread custom exception");

                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured {ex.Message}");
            }
            finally
            {
                Monitor.Exit(_locker);
            }
        }
    }

   
}
