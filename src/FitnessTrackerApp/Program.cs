using System;

namespace FitnessTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your weight (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Your height (cm):");
            double height = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("Your gender (M/F):");
            string gender = Console.ReadLine();

            User user = new User(weight, height, gender, age);

            Console.WriteLine($"Your daily calories norm is: {user.CaloriesNorm()}.\n");
            Console.WriteLine("Let's calculate your weekly progress!\n");

            var score = new WeeklyProgress();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Day {i}:");
                Console.WriteLine("Enter consumed calories value:");
                int caloriesConsumed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your today's running distance (km):");
                double run = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your today's swimming time (min):");
                double swim = Convert.ToDouble(Console.ReadLine()) / 60;
                Console.WriteLine("Your today's walking time (min):");
                double walk = Convert.ToDouble(Console.ReadLine()) / 60;

                Exercises ex = new Exercises(run, swim, walk);

                DailyProgress progress = new DailyProgress(caloriesConsumed, user.CaloriesNorm(), ex.Burned(weight));
                Console.WriteLine($"\nYour daily progress is: {(int)progress.DailyDeviation()}.\n");
                score.deviationFromNorm.Add((int)progress.DailyDeviation());
            }
            
            Console.WriteLine($"Your weekly progress is: {score.WeeklyScore()}");            
        }
    }
}
