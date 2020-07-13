using System;
using System.Threading;

namespace PostOfficeQueueApp
{
    class Counters
    {
        private int _x = 1;

        public Counters(int x)
        {
            _x = x;
        }

        public void Counter1()
        {
            while (_x <= 100)
            {
                Console.WriteLine($"Customer {_x} go to Counter 1.");
                _x++;
                Thread counter2 = new Thread(new ThreadStart(Counter2));
                if (!counter2.IsAlive) counter2.Start();
                Random time = new Random();
                Thread.Sleep(time.Next(3000, 7000));
            }
        }

        public void Counter2()
        {
            while (_x <= 100)
            {
                Console.WriteLine($"Customer {_x} go to Counter 2.");
                _x++;
                Thread counter3 = new Thread(new ThreadStart(Counter3));
                if (!counter3.IsAlive) counter3.Start();
                Random time = new Random();
                Thread.Sleep(time.Next(3000, 7000));
            }
        }

        public void Counter3()
        {
            while (_x <= 100)
            {
                Console.WriteLine($"Customer {_x} go to Counter 3.");
                _x++;                
                Random time = new Random();
                Thread.Sleep(time.Next(3000, 7000));
            }
        }
    }
}
