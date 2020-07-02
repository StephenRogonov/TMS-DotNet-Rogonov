using System;
using ZooApp.Enums;

namespace ZooApp.Models
{
    class Animal
    {
        private readonly Guid _id = Guid.NewGuid();
        private string _passport;
        public Animal()
        { 
            Name = "Noname";
            Kind = KindTypes.None;
            _passport = Guid.NewGuid().ToString();
        }

        public Animal(string name)
        {
            Name = name;
            Kind = KindTypes.None;
            _passport = Guid.NewGuid().ToString();
        }

        public Animal(string name, KindTypes kind)
        {
            Name = name;
            Kind = kind;
        }

        public Animal(string name, KindTypes kind, string passport)
        {
            Name = name;
            Kind = kind;
            _passport = passport;
        }

        public string Name { get; set; }
        public KindTypes Kind { get; set; }

        public Guid GetId()
        {
            return _id;
        }

        public string GetPassport()
        {
            return _passport;
        }

        public void SetPassport(string passport)
        {
            _passport = passport;
        }
    }
}
