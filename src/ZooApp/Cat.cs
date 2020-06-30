using System;

namespace ZooApp
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Meow");
        }
    }
}
