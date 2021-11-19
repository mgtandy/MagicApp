using System;
using System.Threading;
using System.Threading.Tasks;

namespace MagicApp
{
    public class SequentialTaskFactory : IDisposable
    {
        private readonly TaskFactory _sequentialTaskFactory;

        private readonly SequentialScheduler _scheduler;

        public SequentialTaskFactory()
        {
            _scheduler = new SequentialScheduler();
            _sequentialTaskFactory = new TaskFactory(
                CancellationToken.None, TaskCreationOptions.None,
                TaskContinuationOptions.None, _scheduler);
        }

        public Task RunOnBackgroundSequentially(Func<Task> func)
        {
            return _sequentialTaskFactory.StartNew(func).Unwrap();
        }
        public Task<T> RunOnBackgroundSequentially<T>(Func<Task<T>> func)
        {
            return _sequentialTaskFactory.StartNew(func).Unwrap();
        }
        public Task RunOnBackgroundSequentially(Action func)
        {
            return _sequentialTaskFactory.StartNew(func);
        }
        public Task<T> RunOnBackgroundSequentially<T>(Func<T> func)
        {
            return _sequentialTaskFactory.StartNew(func);
        }

        public void Dispose()
        {
            _scheduler?.Dispose();
        }
    }
}