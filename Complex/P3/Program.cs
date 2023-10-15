using System;
namespace DateTimeSubmission;
class Program
{
    public static void Main(string[] args)
    {

        bool value1 = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime dob);
        bool value2 = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime specifiedDate);

        if (value1 & value2)
        {
            TimeSpan age = specifiedDate - dob;
            System.Console.WriteLine("Age : " + (int)age.TotalDays / 365);
            System.Console.WriteLine("Day : " + dob.DayOfWeek);
            System.Console.WriteLine("Number of days : " + (int)age.TotalDays);
            System.Console.WriteLine("Number of hours : " + (long)age.TotalHours);
            System.Console.WriteLine("Number of minutes : " + (long)age.TotalMinutes);

        }
        else
        {
            System.Console.WriteLine("Invalid Date");
        }

    }
}