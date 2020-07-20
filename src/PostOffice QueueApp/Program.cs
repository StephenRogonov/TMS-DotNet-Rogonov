using System;
using System.Collections.Generic;
using System.Threading;

namespace StoreQueueApp
{
    class Program
    {
        public static int storeCashiersCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of buyers: ");
            int.TryParse(Console.ReadLine(), out int buyersCount);
            var buyers = new List<Buyer>();

            for (int i = 0; i < buyersCount; i++)
            {
                buyers.Add(new Buyer());
            }

            Console.WriteLine("Enter number of cashiers: ");
            int.TryParse(Console.ReadLine(), out storeCashiersCount);
            var store = new Store();
            store.ShowCashiers();

            foreach (var buyer in buyers)
            {
                store.BuyerHandler(buyer);
            }
        }
    }
}
