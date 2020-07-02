using System;
using ZooApp.Managers;
using ZooApp.Models;

namespace ZooApp
{
    class Program
    {
        private static readonly AnimalManager _animalManager = new AnimalManager();
        private static readonly ZooManager _zoo = new ZooManager();

        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                int.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        {
                            InputAnimal();
                        }
                        break;

                    case 2:
                    case 3:
                        {
                            Console.WriteLine("Not implemented.");
                        }
                        break;

                    case 4:
                        {
                            _zoo.GetAllAnimals();
                        }
                        break;

                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Action not found.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                }
                Console.WriteLine();
            }
        }

        private static void InputAnimal()
        {
            Console.Write("Enter animal's name: ");
            var name = Console.ReadLine();
            Animal animal;

            if (!string.IsNullOrEmpty(name))
            {
                animal = _animalManager.CreateAnimal(name);
            }
            else
            {
                animal = _animalManager.CreateAnimal();
            }
            Console.WriteLine("Animal successfully created and added to the zoo!");

            _zoo.SetAnimal(animal);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Add animal.");
            Console.WriteLine("2. Delete animal.");
            Console.WriteLine("3. Show animal info.");
            Console.WriteLine("4. Show all animals.");
            Console.WriteLine("5. Exit.");
            Console.WriteLine();
        }
    }
}
