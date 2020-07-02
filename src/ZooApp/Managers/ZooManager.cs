using System;
using System.Collections.Generic;
using System.Text;
using ZooApp.Models;

namespace ZooApp.Managers
{
    class ZooManager
    {
        private readonly AnimalManager _animalManager;
        public List<Animal> animals = new List<Animal>();

        public ZooManager()
        {
            _animalManager = new AnimalManager();
        }

        public void GetAnimal(Animal animal)
        {
            _animalManager.GetInfo(animal);
        }

        public void GetAllAnimals()
        {
            if (animals.Count > 0)
            {
                foreach (var animal in animals)
                {
                    _animalManager.GetInfo(animal);
                }
            }
            else
            {
                Console.WriteLine("Zoo has no animals.");
            }
        }

        public void SetAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void Remove(Animal animal)
        {
            animals.Remove(animal);
        }
    }
}
