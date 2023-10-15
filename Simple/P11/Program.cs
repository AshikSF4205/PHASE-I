using System;
namespace ForSubmission;
class Program
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"{number} * {i} = {i * number}");
        }
    }
}

