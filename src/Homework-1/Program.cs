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
            CurrentDay();

            //Return number of week day by its name
            Console.WriteLine("Enter the Name of week day to know its number:");
            Console.WriteLine(WDNumberByName(Console.ReadLine()));
                        
            //Return week day name by its number
            Console.WriteLine("Enter the number of week day (1-7) to know its name:");
            Console.WriteLine(WDNameByNumber(Convert.ToInt32(Console.ReadLine())));            
        }

        static void CurrentDay()
        {
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
        }

        static string WDNumberByName(string day)
        {            
            day = day.First().ToString().ToUpper() + day.Substring(1).ToLower();
            if (day == "Monday")
            {
                int digit = (int)WeekDays.Monday;
                return $"{day} is the {digit}st day of the week.";
            }
            else if (day == "Tuesday")
            {
                int digit = (int)WeekDays.Tuesday;
                return $"{day} is the {digit}nd day of the week.";
            }
            else if (day == "Wednesday")
            {
                int digit = (int)WeekDays.Wednesday;
                return $"{day} is the {digit}rd day of the week.";
            }
            else if (day == "Thursday")
            {
                int digit = (int)WeekDays.Thursday;
                return $"{day} is the {digit}th day of the week.";
            }
            else if (day == "Friday")
            {
                int digit = (int)WeekDays.Friday;
                return$"{day} is the {digit}th day of the week.";
            }
            else if (day == "Saturday")
            {
                int digit = (int)WeekDays.Saturday;
                return $"{day} is the {digit}th day of the week.";
            }
            else if (day == "Sunday")
            {
                int digit = (int)WeekDays.Sunday;
                return $"{day} is the {digit}th day of the week.";
            }
            else
            {
                return "Please check the spelling.";
            }
        }

        static string WDNameByNumber(int digit)
        {
            switch (digit)
            {
                case 1:
                    string day = WeekDays.Monday.ToString();
                    return $"{digit}st day of the week is {day}.";
                case 2:
                    day = WeekDays.Tuesday.ToString();
                    return $"{digit}nd day of the week is {day}.";
                case 3:
                    day = WeekDays.Wednesday.ToString();
                    return $"{digit}rd day of the week is {day}.";
                case 4:
                    day = WeekDays.Thursday.ToString();
                    return $"{digit}th day of the week is {day}.";
                case 5:
                    day = WeekDays.Friday.ToString();
                    return $"{digit}th day of the week is {day}.";
                case 6:
                    day = WeekDays.Saturday.ToString();
                    return $"{digit}th day of the week is {day}.";
                case 7:
                    day = WeekDays.Sunday.ToString();
                    return $"{digit}th day of the week is {day}.";
                default:
                    return "You have entered a non-numeric value or entered value is out of range!";
            }
        }
    }
}
