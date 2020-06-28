using System;
using System.Security.Cryptography.X509Certificates;
using stopwatch;

namespace stopwatch
{
    class Program
    {
        public TimeSpan elapsed { get; }
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan begin = stopwatch.Start();
            TimeSpan end = stopwatch.Stop();

            
        }
        public TimeSpan ElapsedTime(begin, end)
        {

            TimeSpan duration = end - begin;

            Console.WriteLine(duration);
            
        }
    }
}
