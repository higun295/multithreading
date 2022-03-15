using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample {
    class Program {
        static void Main(string[] args) {

            Task<string> task = GetStringAsync();
            Console.WriteLine(task.Result);
        }

        static async Task<string> GetStringAsync() {
            await Task.Delay(TimeSpan.FromSeconds(2));
            return "Hello World";
        }
    }
}
