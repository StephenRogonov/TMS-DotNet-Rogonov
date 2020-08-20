using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace StoreQueueApp
{
    class Store
    {
        private static SemaphoreSlim semaphore = new SemaphoreSlim(Program.storeCashiersCount);
        private Thread thread;

        public IList<Cashiers> Cashiers { get; set; } = new List<Cashiers>();

        public Store()
        {
            GenerateCashier();
        }

        public void ShowCashiers()
        {
            foreach (var cashier in Cashiers)
            {
                Console.WriteLine(cashier.Id);
                Console.WriteLine(cashier.Speed);
                Console.WriteLine(cashier.IsFree);
                Console.WriteLine();
            }
        }

        private object locker = new object();

        public void BuyerHandler(Buyer buyer)
        {
            thread = new Thread(ServeBuyer)
            {
                Name = Guid.NewGuid().ToString()
            };

            thread.Start(buyer);
        }

        private void ServeBuyer(object obj)
        {
            semaphore.Wait();

            var buyer = (Buyer)obj;

            Cashiers selectedCashier;

            bool acquiredLock = false;

            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                selectedCashier = Cashiers.FirstOrDefault(c => c.IsFree == true);
                selectedCashier.IsFree = false;
            }
            finally
            {
                if (acquiredLock) Monitor.Exit(locker);
            }

            Console.WriteLine($"Cahier {selectedCashier.Id} started serving buyer {buyer.Id} {Thread.CurrentThread.Name}");
            var time = buyer.Basket.Count * selectedCashier.Speed;
            Thread.Sleep(time);
            Console.WriteLine($"Cahier {selectedCashier.Id} finished serving buyer {buyer.Id}, serving time: {time}");
            selectedCashier.IsFree = true;

            semaphore.Release();
        }

        private void GenerateCashier()
        {
            for (int i = 0; i < Program.storeCashiersCount; i++)
            {
                var random = new Random();
                Cashiers.Add(new Cashiers
                {
                    Speed = random.Next(1000, 2000),
                });
            }
        }
    }
}
