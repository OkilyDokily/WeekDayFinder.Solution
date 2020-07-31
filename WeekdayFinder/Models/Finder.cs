using System.Text.RegularExpressions;
using System;

namespace WeekdayFinder.Models
{
    public class Finder
    {
        public static string DayOfWeek(string str){
            DateTime date = DateTime.Parse(str);
            return date.DayOfWeek.ToString();
        }
    }
}