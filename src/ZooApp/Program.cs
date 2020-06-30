using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat("Tkumwa");
            Console.WriteLine(cat.Name);
            cat.Say();
        }
    }
}
