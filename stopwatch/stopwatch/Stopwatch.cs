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

        public TimeSpan Start()
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
            return;
        }

        public TimeSpan Stop()
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

            return;
        }

        public int[] Foo(int x, params int[] y)
        {
            return y;
        }
    }
}
