using Microsoft.VisualBasic;
using System;

namespace ToDo_Console_App
{
    public class Task
    {
        public Task() { }

        public string Name { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Date} {Time} - {Name}");
        }
    }
}
