using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Api
{
    public class ApiClient
    {
        public int LastThreadId { get; set; } = 0;
        private object _lock = new object();

        public Task LongRunningLockedTask(int nth)
        {
            lock (_lock)
            {
                Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting long running task...");

                var answer = FindPrimeNumber(nth);
      
                Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finishing long running task... Answer: {answer}");

                LastThreadId = Thread.CurrentThread.ManagedThreadId;
            }

            return Task.CompletedTask;
        }

        public Task LongRunningTask(int nth)
        {
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting long running task...");

            var answer = FindPrimeNumber(nth);

            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finishing long running task... Answer: {answer}");

            LastThreadId = Thread.CurrentThread.ManagedThreadId;

            return Task.CompletedTask;
        }

        private long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
