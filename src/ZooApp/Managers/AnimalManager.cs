using System;
using ZooApp.Enums;
using ZooApp.Interfaces;
using ZooApp.Models;

namespace ZooApp.Managers
{
    class AnimalManager : IAnimalManager
    {
        public void GetInfo(Animal animal)
        {
            Console.WriteLine($"ID: {animal.GetId()}");
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Kind: {animal.Kind}");
            Console.WriteLine($"Passport: {animal.GetPassport()}");
        }

        public void Rename(Animal animal, string name)
        {
            animal.Name = name;
        }

        public void SetPassport(Animal animal, string passport)
        {
            animal.SetPassport(passport);
        }

        public Animal CreateAnimal()
        {
            return new Animal();
        }

        public Animal CreateAnimal(string name)
        {
            return new Animal(name);
        }

        public Animal CreateAnimal(string name, KindTypes kind)
        {
            return new Animal(name, kind);
        }

        public Animal CreateAnimal(string name, KindTypes kind, string passport)
        {
            return new Animal(name, kind, passport);
        }
    }
}
