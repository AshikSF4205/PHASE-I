using System;

namespace P9;

class Program
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());
        int answer = 1;

        for (int i = 0; i < power; i++)
        {
            answer *= number;
        }

        Console.WriteLine(answer);

    }
}

