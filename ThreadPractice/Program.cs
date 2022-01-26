using System;
using System.Threading;

namespace ThreadPractice {
    class Node {
        public string Text { get; set; }
        public int Count { get; set; }
        public int Tick { get; set; }
    }

    class Program {
        static void ThreadProc(Object callback) {
            if(callback.GetType() != typeof(Node)) return;

            var node = (Node)callback;
            for(int i = 0; i < node.Count; i++) {
                Console.WriteLine(node.Text + " = " + i);
                Thread.Sleep(node.Tick);
            }
            Console.WriteLine("Complete " + node.Text);
        }
        static void Main(string[] args) {
            if(ThreadPool.SetMinThreads(0, 0) && ThreadPool.SetMaxThreads(2, 0)) {
                ThreadPool.QueueUserWorkItem(ThreadProc, new Node { Text = "A", Count = 3, Tick = 1000 });
                ThreadPool.QueueUserWorkItem(ThreadProc, new Node { Text = "B", Count = 5, Tick = 10 });
                ThreadPool.QueueUserWorkItem(ThreadProc, new Node { Text = "C", Count = 2, Tick = 500 });
                ThreadPool.QueueUserWorkItem(ThreadProc, new Node { Text = "D", Count = 7, Tick = 300 });
                ThreadPool.QueueUserWorkItem(ThreadProc, new Node { Text = "E", Count = 4, Tick = 200 });
            }

            Console.WriteLine("Press Any Key ... ");
            Console.ReadLine();
        }
    }
}