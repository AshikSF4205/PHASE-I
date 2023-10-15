using System;
namespace ForSubmission;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the lower and upper limits:");
        int lower = int.Parse(Console.ReadLine());
        int upper = int.Parse(Console.ReadLine());
        long sqSums = 0;

        for (int i = lower; i <= upper; i++)
        {
            sqSums += i * i;
        }

        Console.WriteLine("Sum of the square of the numbers: " + sqSums);

        Console.WriteLine("\n\nEven numbers between 100 & 10:\n");

        for (int i = 100; i >= 10; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

        }


    }
}

