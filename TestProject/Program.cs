using System;

namespace TestProject {
    class Program {
        static void Main(string[] args) {
            int length = 10;
            var actions = new Action[length];

            Console.WriteLine($"클로저(closure) 문제 해결");

            for(var index = 0; index < length; index++) {
                var localIndex = index;
                actions[index] = () => Console.WriteLine(localIndex);
            }

            foreach(var item in actions) {
                item?.Invoke();
            }
        }
    }
}
