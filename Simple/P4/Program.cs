
using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {
        double salary = Convert.ToDouble(Console.ReadLine());

        double da = salary * 0.1, hra = salary * 0.1;

        double netPay = salary + da + hra;

        double tax = netPay * 0.05;

        double perMonthSalary = netPay - tax;

        Console.WriteLine(perMonthSalary*12);


    }
}
