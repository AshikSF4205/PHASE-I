using System;
namespace P13;
class Program
{
    public static void Main(string[] args)
    {
        int number, i, half = 0, flag = 0;
        number = int.Parse(Console.ReadLine());
        if (number == 1 || number == 0)
        {
            Console.Write(number + " is a not prime number");
        }
        else
        {
            half = number / 2;
            for (i = 2; i <= half; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(number + " is a not prime number");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(number + " is a prime number");
        }
    }
}
