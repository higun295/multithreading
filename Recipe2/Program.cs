using System;
using System.Threading;
using static System.Console;
using static System.Threading.Thread;

namespace Recipe2 {
    class Program {
        static void Main(string[] args) {
            Thread t = new Thread(PrintNumbersWithDelay);
            t.Start();
            PrintNumbers();
        }
        static void PrintNumbers() {
            WriteLine("1 Starting...");
            for(int i = 1; i < 10; i++) {
                WriteLine(i);
            }
        }
        static void PrintNumbersWithDelay() {
            WriteLine("2 Starting...");
            for(int i = 1; i < 10; i++) {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine(i);
            }
        }
    }
}
