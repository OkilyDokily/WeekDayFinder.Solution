using System;
using WeekdayFinder.Models;
namespace WeekdayFinder
{
    public class Program
    {
        public static void Main(){
           Console.WriteLine("Enter a date");
           Console.WriteLine("For Example - 7/11/14");
           string str = Console.ReadLine();
           string result = Finder.DayOfWeek(str);
           Console.WriteLine("The day of week on that day is " + result);
        }
    }
}