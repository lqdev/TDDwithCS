using System;
using System.Threading;

namespace HandMocking.Moq
{
    public class LongRunningLibrary : ILongRunningLibrary 
    {
        public string RunForALongTime(int interval)
        {
            var timeToWait = interval * 1000;
            Thread.Sleep(timeToWait);
            return string.Format("Waited {0} seconds",interval);
        }
    }
}