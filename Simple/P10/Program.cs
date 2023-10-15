using System;
namespace ForSubmission;
class Program
{
    public static void Main(string[] args)
    {
        int lower = int.Parse(Console.ReadLine());
        int upper = int.Parse(Console.ReadLine());
        long sqSums = 0;

        for (int i = lower; i <= upper; i++)
        {
            if (i % 2 == 1)
                sqSums += i * i;
        }

        Console.WriteLine(sqSums);


    }
}

