using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp.Threadings.Locking
{
    public class ReadWriteLock
    {
        private ReaderWriterLockSlim lockSlim = new ReaderWriterLockSlim();
        private Dictionary<int, string> innerDictionary = new Dictionary<int, string>();

        // Write operation: When a thread wants to write, it checks whether any other thread is reading or writing.
        // If yes, it will wait until all threads have finished.
        public void Add(int key, string value)
        {
            lockSlim.EnterWriteLock();
            try
            {
                innerDictionary.Add(key, value);
            }
            finally
            {
                lockSlim.ExitWriteLock();
            }
        }

        // Read operation: When a thread wants to read, it checks whether any other thread is writing.
        // If yes, it will wait until the write operation has finished.
        public string Read(int key)
        {
            lockSlim.EnterReadLock();
            try
            {
                return innerDictionary[key];
            }
            finally
            {
                lockSlim.ExitReadLock();
            }
        }

        // Update operation: This is a combination of read and write operation.
        // It first locks the dictionary for reading to fetch the value, and then locks it for writing to update the value.
        public void Update(int key, string value)
        {
            lockSlim.EnterUpgradeableReadLock();
            try
            {
                if (innerDictionary.ContainsKey(key))
                {
                    lockSlim.EnterWriteLock();
                    try
                    {
                        innerDictionary[key] = value;
                    }
                    finally
                    {
                        lockSlim.ExitWriteLock();
                    }
                }
            }
            finally
            {
                lockSlim.ExitUpgradeableReadLock();
            }
        }
    }

    public class ReadWriteLockClient
    {
        public static void Test()
        {
            ReadWriteLock readWriteLock = new ReadWriteLock();

            // Test Add method
            readWriteLock.Add(1, "Value1");
            Console.WriteLine("Added key 1 with value 'Value1'");

            // Test Read method
            string value = readWriteLock.Read(1);
            Console.WriteLine($"Read key 1 with value '{value}'");

            // Test Update method
            readWriteLock.Update(1, "UpdatedValue1");
            value = readWriteLock.Read(1);
            Console.WriteLine($"Updated key 1 with value '{value}'");
        }
    }
}
