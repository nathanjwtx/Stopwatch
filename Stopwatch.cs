using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime StartTime { get; set; }

        private bool Started { get; set; }

        public void StartStopwatch()
        {
            Started = true;
            this.StartTime = StartTime;
        }

        public DateTime TodaysDate => StartTime;

        public int Stop
        {
            get
            {
                Started = false;
                var stoptime = DateTime.Now;
                var timespan = stoptime - StartTime;
                return Convert.ToInt32(timespan.Seconds);
            }
        }
    }
}