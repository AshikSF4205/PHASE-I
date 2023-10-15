using System;
namespace WhileSubmission;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\nEnter Valid Number program\n");
        long num;
        System.Console.WriteLine("Enter the Number: ");

        while (!long.TryParse(Console.ReadLine(), out num))
        {
            System.Console.WriteLine("Invalid Number, Re-Enter the Number: ");
        }

        System.Console.WriteLine(num + " is Valid number");
    }
}