using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class Scheduler
    {
        private readonly ConcurrentQueue<Action> _tasks = new ConcurrentQueue<Action>();
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public void Start()
        {
            int workerCount = Environment.ProcessorCount; // Number of logical processors

            for (int i = 0; i < workerCount; i++)
            {
                Task.Run(async () =>
                {
                    while (true)
                    {
                        if (_cancellationTokenSource.Token.IsCancellationRequested)
                            break;

                        if (_tasks.TryDequeue(out var task))
                            task();
                        else
                            await Task.Delay(TimeSpan.FromMilliseconds(100));
                    }
                });
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }

        public void Schedule(Action task)
        {
            _tasks.Enqueue(task);
        }
    }

   
}
