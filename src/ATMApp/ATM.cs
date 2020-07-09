using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM_App
{
    class ATM
    {
        public delegate void ATMHandler(string message);
        public event ATMHandler Notify;

        private IList<Client> clients = new List<Client>();

        public void Withdrawal(string id, decimal amount)
        {
            Client client = clients.SingleOrDefault(c => c.id == id);
            if (client != null)
            {
                decimal clientBalance = client.GetBalance();
                if (clientBalance > amount)
                {
                    client.UpdateBalance(amount);
                    Notify?.Invoke($"Please take your money.\nRemaining balance is: {client.GetBalance()}");
                }
                else
                {
                    Notify?.Invoke("Insufficient funds.");
                }
            }
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
    }
}