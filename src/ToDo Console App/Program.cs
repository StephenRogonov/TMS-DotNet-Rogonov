using System;
using System.Collections.Generic;

namespace ToDo_Console_App
{
    class Program
    {
        static void Main()
        {
            List<Task> tasks = new List<Task>(5);
            
            var task1 = new Task()
            {
                Date = DateTime.Now.ToString("dd.MM"),
                Name = "Wake up",
                Time = "09:00"
            };

            var task2 = new Task()
            {
                Date = DateTime.Now.ToString("dd.MM"),
                Name = "Breakfast",
                Time = "10:00"
            };

            var task3 = new Task()
            {
                Date = DateTime.Now.ToString("dd.MM"),
                Name = "Work",
                Time = "11:00"
            };

            var task4 = new Task()
            {
                Date = DateTime.Now.ToString("dd.MM"),
                Name = "Lunch",
                Time = "14:00"
            };

            var task5 = new Task()
            {
                Date = DateTime.Now.ToString("dd.MM"),
                Name = "Dinner",
                Time = "20:00"
            };            

            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);

            foreach (Task t in tasks)
            {
                t.Show();
            }
        }
    }
}
