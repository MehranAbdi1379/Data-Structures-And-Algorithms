using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_And_Algorithms
{
    public class Timing
    {
        public TimeSpan StartTime;
        public TimeSpan Duration;

        public Timing()
        {
            StartTime = new TimeSpan(0);
            Duration = new TimeSpan(0);
        }

        public void StartTimer()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            StartTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public void EndTimer()
        {
            Duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(StartTime);
        }

        public double Result()
        {
            return Duration.TotalSeconds;
        }
    }
}
