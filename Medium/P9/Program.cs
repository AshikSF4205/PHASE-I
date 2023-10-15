using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 10)
        {
            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 1; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }
            int a, b, c, d;
            for (int i = 10; i <= n; i++)
            {
                a = i / 100;
                b = (i - a * 100) / 10;
                c = (i - a * 100 - b * 10);
                d = a * a * a + b * b * b + c * c * c;
                if (i == d)
                {
                    System.Console.WriteLine(i);
                }
            }

        }

    }
}