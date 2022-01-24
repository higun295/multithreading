using System;
using System.Threading;
using static System.Console;

namespace Recipe2 {
    class Program {
        static void Main(string[] args) {
            const string MutexName = "CSharpThreadingCookbook";

            using(var m = new Mutex(false, MutexName)) {

            }
        }
    }
}
