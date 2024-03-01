using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings
{
    public class ThreadException
    {
        public async Task Test()
        {
            //string res = await ThrowException();
            try
            {
                ThrowException1();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);
            }

            var task1 = ThrowException2();
            var task2 = ThrowException3();

            try
            {
                Task.WaitAll(task1, task2); ;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);

            }


            var task3 = ThrowException2();
            var task4 = ThrowException3();

            //var whenAllTask = Task.WhenAll(task1, task2);
            var whenAllTask = Task.WhenAll(task3, task4);

            try
            {
                await whenAllTask;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);

            }

            try
            {
                await ThrowException3();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Testing exception tasks", ex.Message);

            }
            Console.WriteLine("Testing exception tasks");

        }

        public async Task<string> ThrowException()
        {
            throw new Exception("Custom exception");
        }

        public async Task<string> ThrowException1()
        {
            throw new Exception("Custom exception 1");
        }

        public async Task<string> ThrowException2()
        {
            throw new Exception("Custom exception 2");
        }

        public async Task<string> ThrowException3()
        {
            throw new Exception("Custom exception 3");
        }
    }
}
