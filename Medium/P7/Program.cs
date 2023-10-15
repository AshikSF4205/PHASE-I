using System;

namespace P7;

public class Program
{

    static int fact(int number)
    {

        int i, fact = 1;

        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    public static void Main(string[] args)
    {
        number = int.Parse(Console.ReadLine());
        Console.WriteLine(fact(number));
    }
}
