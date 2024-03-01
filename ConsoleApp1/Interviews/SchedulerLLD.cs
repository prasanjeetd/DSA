using System.Collections.Concurrent;

namespace ConsoleApp1.Interviews
{
    public interface IJob
    {
        void Work();
        void OnComplete();
    }

    public class Job : IJob
    {
        public void Work()
        {
            // Job implementation
        }

        public void OnComplete()
        {
            // OnComplete implementation
        }
    }

    public class SchedulerAsync
    {
        private static readonly Lazy<SchedulerAsync> _instance = new Lazy<SchedulerAsync>(() => new SchedulerAsync());

        private readonly ConcurrentQueue<IJob> _jobs = new ConcurrentQueue<IJob>();
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private SchedulerAsync() { }

        public static SchedulerAsync Instance => _instance.Value;

        public void AddJob(IJob job)
        {
            _jobs.Enqueue(job);
        }

        public void Start()
        {
            int workerCount = Environment.ProcessorCount; // Number of logical processors

            Parallel.For(0, workerCount, i =>
            {
                while (true)
                {
                    if (_cancellationTokenSource.Token.IsCancellationRequested)
                        break;

                    if (_jobs.TryDequeue(out var job))
                    {
                        job.Work();
                        job.OnComplete();
                    }
                    else
                        Thread.Sleep(100);
                }
            });
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }
    }


    public class ShedulerTest
    {
        public void Test()
        {

            // Usage
            var job1 = new Job();
            var job2 = new Job();

            var scheduler = SchedulerAsync.Instance;
            scheduler.AddJob(job1);
            scheduler.AddJob(job2);
            scheduler.Start();
        }
    }

}