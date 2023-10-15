using System;
namespace P7;
class Program
{
    public static void Main(string[] args)
    {
        int speed = int.Parse(Console.ReadLine());
        if (speed <= 10)
        {
            System.Console.WriteLine("slow");
        }
        else if (speed > 10 && speed <= 50)
        {
            System.Console.WriteLine("average");
        }
         else if (speed > 50 && speed <= 150)
        {
            System.Console.WriteLine("fast");
        }
         else if (speed > 150 && speed <= 200)
        {
            System.Console.WriteLine("ultra fast");
        }
        else if (speed > 200)
        {
            System.Console.WriteLine("extremely fast");
        }
    }
}
