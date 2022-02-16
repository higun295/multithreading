using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestProject {
    class Program {
        static void Main(string[] args) {
            Task<int> task = new Task<int>(() => {
                Console.WriteLine("TEST0");
                Thread.Sleep(5000);
                return 1;
            });

            task.Start();
            task.ContinueWith((arg) => {
                Console.WriteLine("TEST1");
            });


            //int length = 10;
            //var actions = new Action[length];

            //Console.WriteLine($"클로저(closure) 문제 해결");

            //for(var index = 0; index < length; index++) {
            //    var localIndex = index;
            //    actions[index] = () => Console.WriteLine(localIndex);
            //}

            //foreach(var item in actions) {
            //    item?.Invoke();
            //}
        }
    }
}
