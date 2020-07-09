using System;

namespace ATM_App
{
    class Client
    {
        public readonly string id;
        private decimal _balance;

        public Client(decimal balance)
        {
            id = Guid.NewGuid().ToString();
            _balance = balance;
        }

        public void UpdateBalance(decimal money)
        {
            _balance -= money;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void GetBalanceInfo()
        {            
            Console.WriteLine($"Your current balance is: {_balance}");
        }
    }
}