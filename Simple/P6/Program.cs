using System;
namespace P6;
class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if (number < 100)
        {
            System.Console.WriteLine("Less than 100.");
        }
        else if (number >= 100 && number <= 200)
        {
            System.Console.WriteLine("Between 100 and 200.");
        }
        else if (number > 200)
        {
            System.Console.WriteLine("Greater than 200.");
        }
    }
}
