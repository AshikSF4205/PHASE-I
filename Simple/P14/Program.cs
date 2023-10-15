
using System;
namespace DateTimeSubmission;
class Program
{
    public static void Main(string[] args)
    {

        string fullDate = Console.ReadLine();


        bool value = DateTime.TryParseExact(fullDate, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime result);

        if (value)
        {
            Console.WriteLine($"The day of the week for {result.ToString("MM/dd/yyyy")} is {result.DayOfWeek}");
        }
        else
        {
            Console.WriteLine("Invalid Date");
        }
    }
}