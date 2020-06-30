namespace ZooApp
{
    public class Animal
    {       
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Kind { get; set; }
        public bool Gender { get; set; }

        public virtual void Say()
        {
            System.Console.WriteLine("I can say something.");
        }
    }
}
