using ConsoleApp1.Interviews;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings
{
    public class WaitAllAndWhenAll
    {
        public async Task Test()
        {
            var t1 = Diplay();
            var t2 = Diplay1();

            Console.WriteLine("Waiting Task by wait all");

            Task.WaitAll(t1, t2);

            Console.WriteLine("Completed Task by wait all");

            var t3 = Diplay2();
            var t4 = Diplay3();

            Console.WriteLine("Waiting Task by when all");

            await Task.WhenAll(t3, t4);

            Console.WriteLine("Completed Task by when all");
        }

        public void Test1()
        {
            var t1 = Diplay();
            var t2 = Diplay1();

            Console.WriteLine("Waiting Task by wait all");

            Task.WaitAll(t1, t2);

            Console.WriteLine("Completed Task by wait all");

            var t3 = Diplay2();
            var t4 = Diplay4();

            Console.WriteLine("Waiting Task by when all");

            Task.WaitAll(t3, t4);

            Console.WriteLine($"Task 4 compeleted {t4.Result}");


            Console.WriteLine("Completed Task by when all");
        }

        public void Test2()
        {
            var TaskList = new List<Task>();

            for (int i = 0; i < 3; i++)
            {
                int idx = i;
                TaskList.Add(Foo(idx));
            }

            Task.WaitAll(TaskList.ToArray());

            //var t3 = Diplay2();
            //var t4 = Diplay3();
            //Task.WhenAll(t3, t4);

            Console.WriteLine("Press Enter to exit...");
        }

        public async Task Foo(int num)
        {
            Console.WriteLine("Thread {0} - Start {1}", Thread.CurrentThread.ManagedThreadId, num);

            await Task.Delay(3000);

            Console.WriteLine("Thread {0} - End {1}", Thread.CurrentThread.ManagedThreadId, num);
        }

        public Task<string> Diplay()
        {
            Console.WriteLine("Thread {0} - Start ", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);

            Console.WriteLine("Thread {0} - End ", Thread.CurrentThread.ManagedThreadId);

            return Task.Run(() => "Hello1");
        }

        public Task<string> Diplay1()
        {
            Console.WriteLine("Thread {0} - Start ", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);

            Console.WriteLine("Thread {0} - End ", Thread.CurrentThread.ManagedThreadId);

            return Task.Run(() => "World1");
        }

        public async Task<string> Diplay2()
        {
            Console.WriteLine("Thread {0} - Start ", Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(5000);
            //return await Task.Run(() => "Hello2");
            Console.WriteLine("Thread {0} - End ", Thread.CurrentThread.ManagedThreadId);

            return "Hello2";
        }

        public async Task<string> Diplay3()
        {
            Console.WriteLine("Thread {0} - Start ", Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(5000);

            //return await Task.Run(() => "World2");

            Console.WriteLine("Thread {0} - End ", Thread.CurrentThread.ManagedThreadId);

            return "World2";
        }

        public async Task<string> Diplay4()
        {
            Console.WriteLine("Thread {0} - Start ", Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(5000);

            return await Task.Run(() => "World2");


        }
    }
}
