using System;
using System.Threading;

namespace PostOfficeQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Counters counters = new Counters(1);
            Thread counter1 = new Thread(new ThreadStart(counters.Counter1));            
            counter1.Start();
        }
    }
}
