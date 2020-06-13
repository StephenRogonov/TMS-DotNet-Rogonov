using System;
using System.Linq;

namespace Homework_1
{
    class Program
    {
        enum WeekDays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            //Write Current day of the weeek with its number
            string today = DateTime.Now.DayOfWeek.ToString();
            string number;
            if (today == WeekDays.Monday.ToString())
            {
                number = "1st";
            }
            else if (today == WeekDays.Tuesday.ToString())
            {
                number = "2nd";
            }
            else if (today == WeekDays.Wednesday.ToString())
            {
                number = "3rd";
            }
            else if (today == WeekDays.Thursday.ToString())
            {
                number = "4th";
            }
            else if (today == WeekDays.Friday.ToString())
            {
                number = "5th";
            }
            else if (today == WeekDays.Saturday.ToString())
            {
                number = "6th";
            }
            else
            {
                number = "7th";
            }

            Console.WriteLine($"Today is {today}, {number} day of thee week.");

            //Return number of week day by its name
            Console.WriteLine("Type the Name of week day to know its number:");
            string day = Console.ReadLine();
            day = day.First().ToString().ToUpper() + day.Substring(1).ToLower();
            int digit = 0;
            if (day == "Monday")
            {
                digit = (int)WeekDays.Monday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Tuesday")
            {
                digit = (int)WeekDays.Tuesday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Wednesday")
            {
                digit = (int)WeekDays.Wednesday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Thursday")
            {
                digit = (int)WeekDays.Thursday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Friday")
            {
                digit = (int)WeekDays.Friday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Saturday")
            {
                digit = (int)WeekDays.Saturday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else if (day == "Sunday")
            {
                digit = (int)WeekDays.Sunday;
                Console.WriteLine($"{day} is {digit} day of the week.");
            }
            else
            {
                Console.WriteLine("Please check the spelling.");
            }
            
            //Return week day name by its number
            Console.WriteLine("Enter the number of week day (1-7):");
            digit = Convert.ToInt32(Console.ReadLine());
            switch (digit)
            {
                case 1:
                    day = DayOfWeek.Monday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 2:
                    day = DayOfWeek.Tuesday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 3:
                    day = DayOfWeek.Wednesday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 4:
                    day = DayOfWeek.Thursday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 5:
                    day = DayOfWeek.Friday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 6:
                    day = DayOfWeek.Saturday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                case 7:
                    day = DayOfWeek.Sunday.ToString();
                    Console.WriteLine($"{digit} day of the week is {day}");
                    break;
                default:
                    Console.WriteLine("You have typed a non-numeric value or entered value is out of range!");
                    break;
            }            
        }
    }
}
