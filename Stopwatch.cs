using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start { get; set; }
        private DateTime _stop { get; set; }

        public void StartClock()
        {
            this._start = DateTime.Now;
            Console.WriteLine(_start);
        }

        public int StopClock()
        {
            this._stop = DateTime.Now;
            Console.WriteLine(_stop);
            Console.WriteLine(_start);
            var span = _stop.Subtract(_start);
            return span.Seconds;
        }
        
    }
}