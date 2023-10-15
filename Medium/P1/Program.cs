using System;
namespace P1;
public class Program
{
    public static void Main(string[] args)
    {
        double salary = Convert.ToDouble(Console.ReadLine());
        int month = Convert.ToInt32(Console.ReadLine());
        int year = Convert.ToInt32(Console.ReadLine());
        int leave = Convert.ToInt32(Console.ReadLine());

        int noOfDays = DateTime.DaysInMonth(year, month);

        double perDaySalary = salary / noOfDays;

        int daysWorked = noOfDays - leave;


        Console.WriteLine(Math.Round(perDaySalary * daysWorked, 2));


    }
}
