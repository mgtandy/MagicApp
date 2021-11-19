using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Api;

namespace MagicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int nthPrime = 100000;
        private ApiClient _apiClient;
        public MainWindow()
        {
            InitializeComponent();
             _apiClient = new ApiClient();
        }
        
        private async void TaskRun_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningTask(nthPrime))
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
        }

        private async void TaskRunLocked_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),

                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime)),
                Task.Run(() => _apiClient.LongRunningLockedTask(nthPrime))
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");

        }

        private async void StartWorkWhenAll_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime)
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");

        }

        private async void StartWorkWhenAllArray_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            var tasks = new Task[]
            {
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime)
            };

            await Task.WhenAll(tasks);

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");

        }

        private async void StartWorkWhenAllLocked_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),

                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime),
                _apiClient.LongRunningTask(nthPrime)
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
        }

        private async void StartWorkWhenAllLockedArray_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            var tasks = new Task[]
            {
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                            
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                         
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                 
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime),
                _apiClient.LongRunningLockedTask(nthPrime)
            };

            await Task.WhenAll(tasks);

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");

        }

        private void StartWorkFireAndForget_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);

            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);

            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);

            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);
            _apiClient.LongRunningTask(nthPrime);

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
        }

        private void StartWorkFireAndForgetLocked_Click(object sender, RoutedEventArgs e)
        {
            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
             
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
             
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);
            _apiClient.LongRunningLockedTask(nthPrime);

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
        }

        private async void StartWorkSequential_Click(object sender, RoutedEventArgs e)
        {
            SequentialTaskFactory factory = new SequentialTaskFactory();

            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
            factory.Dispose();
        }

        private async void StartWorkSequential2_Click(object sender, RoutedEventArgs e)
        {
            SequentialTaskFactory factory = new SequentialTaskFactory();
            SequentialTaskFactory factory1 = new SequentialTaskFactory();
            SequentialTaskFactory factory2 = new SequentialTaskFactory();
            SequentialTaskFactory factory3 = new SequentialTaskFactory();

            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),

                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningTask(nthPrime)),
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
            factory.Dispose();
            factory1.Dispose();
            factory2.Dispose();
            factory3.Dispose();
        }

        private async void StartWorkSequentialLocked_Click(object sender, RoutedEventArgs e)
        {
            SequentialTaskFactory factory = new SequentialTaskFactory();

            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                                                                       
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                                                                           
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                                                                 
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
            factory.Dispose();
        }

        private async void StartWorkSequential2Locked_Click(object sender, RoutedEventArgs e)
        {
            SequentialTaskFactory factory = new SequentialTaskFactory();
            SequentialTaskFactory factory1 = new SequentialTaskFactory();
            SequentialTaskFactory factory2 = new SequentialTaskFactory();
            SequentialTaskFactory factory3 = new SequentialTaskFactory();

            var sw = Stopwatch.StartNew();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Starting work...");

            await Task.WhenAll(new Task[]
            {
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),

                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory1.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                                                                             
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory2.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                                                                         
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
                factory3.RunOnBackgroundSequentially(() => _apiClient.LongRunningLockedTask(nthPrime)),
            });

            sw.Stop();
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished long work. Time took: {sw.Elapsed}");
            Debug.WriteLine($"Last thread id: {_apiClient.LastThreadId}");
            factory.Dispose();
            factory1.Dispose();
            factory2.Dispose();
            factory3.Dispose();
        }
    }
}
