using System;
using stopwatch;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();
            var begin = stopwatch.Start();
            var end = stopwatch.Stop();

            TimeSpan duration = end - begin;

            Console.WriteLine(duration);
            
        }
    }
}
