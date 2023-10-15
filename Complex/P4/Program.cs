using System;

namespace P4;

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

        int numberValue = Convert.ToInt32(Console.ReadLine());
        int nTerms = Convert.ToInt32(Console.ReadLine());
        double taylorSeries = 1 + numberValue;
        for (int i = 2; i < nTerms; i++)
        {
            taylorSeries += (Math.Pow(numberValue, i)) / fact(i);
        }

        Console.WriteLine(Math.Round(taylorSeries, 2));

    }
}
