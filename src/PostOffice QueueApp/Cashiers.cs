using System;
using System.Threading;

namespace StoreQueueApp
{
    class Cashiers
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Speed { get; set; }
        public bool IsFree { get; set; } = true;
    }
}
