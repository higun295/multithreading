using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace Recipe6 {
    class Program {
        static Timer _timer;

        static void Main(string[] args) {
            WriteLine("Press 'Enter' to sop the timer...");
            DateTime start = DateTime.Now;
            _timer = new Timer(_ => TimerOperation(start),
                               null,
                               TimeSpan.FromSeconds(1),
                               TimeSpan.FromSeconds(2));
            try {
                Sleep(TimeSpan.FromSeconds(6));
                _timer.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(4));
                ReadLine();
            }
            finally {
                _timer.Dispose();
            }
        }
        static void TimerOperation(DateTime start) {
            TimeSpan elapsed = DateTime.Now - start;
            WriteLine($"{elapsed.Seconds} seconds from {start}. " +
                      $"Timer thread pool thread id : {CurrentThread.ManagedThreadId}");
        }
    }
}