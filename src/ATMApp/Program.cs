using System;

namespace ATM_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var atm = new ATM();
            atm.Notify += ShowMessage;
            var client = new Client(113.83M);
            atm.AddClient(client);

            while (true)
            {
                Options();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            client.GetBalanceInfo();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter amount: \n");
                            atm.Withdrawal(client.id, Convert.ToDecimal(Console.ReadLine()));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter amount in USD: \n");
                            atm.Withdrawal(client.id, Convert.ToDecimal(Console.ReadLine()) * 2.4M);
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void Options()
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Check your balance.");
            Console.WriteLine("2. Withdrawal.");
            Console.WriteLine("3. Withdraw USD.");
            Console.WriteLine("4. Give back card.");
            Console.WriteLine();
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}