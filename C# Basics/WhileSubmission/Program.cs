using System;
namespace WhileSubmission;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Even Number program\n");
        int i = 0, sum = 0;
        System.Console.WriteLine("Even Numbers:");
        while (i <= 25)
        {
            if (i == 0)
            {
                i++;
                continue;
            }
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                sum += i;
            }
            i++;
        }
        System.Console.WriteLine("Sum of Even Numbers:" + sum);

    }
}