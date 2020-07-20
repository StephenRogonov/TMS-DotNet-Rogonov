using System;
using System.Collections.Generic;

namespace StoreQueueApp
{
    class Buyer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public IList<Product> Basket { get; set; } = new List<Product>();

        public Buyer()
        {
            FillBasket();
            Console.WriteLine($"Buyer found: {Id}, basket: {Basket.Count} items.");
        }
        private void FillBasket()
        {
            var random = new Random();
            var productsCount = random.Next(1, 10);
            for (int i = 0; i < productsCount; i++)
            {
                Basket.Add(new Product());
            }
        }
    }
}
