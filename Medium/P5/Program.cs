//an = a1+(n-1)d
//S n = n/2 (2a + (n-1)d)

using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {

        int start = Convert.ToInt32(Console.ReadLine());
        int difference = Convert.ToInt32(Console.ReadLine());
        int noOfElements = Convert.ToInt32(Console.ReadLine());

        int sumOfAP = (noOfElements / 2) * ((2 * start) + ((noOfElements - 1) * difference));

        Console.WriteLine(sumOfAP);

    }
}