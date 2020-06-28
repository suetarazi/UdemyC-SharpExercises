using System;
using System.Collections.Generic;
using System.Text;

namespace stopwatch
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _isRunning;

        public void Start()
        {
            if(_isRunning == true)
            {
                Console.WriteLine("Timer is already started");
            }
            else
            {
                _start = DateTime.Now;
                _isRunning = true;
            }
        }

        public void Stop()
        {
            if(_isRunning == true)
            {
                _stop = DateTime.Now;
                _isRunning = false;
            }
            else
            {
                Console.WriteLine("Timer is not running");
            }

        }

        public int[] Foo(int x, params int[] y)
        {
            return y;
        }
    }
}
