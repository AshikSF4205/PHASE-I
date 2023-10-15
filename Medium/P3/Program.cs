using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        for (int i = 1; i <= N; i++)
        {
            if (i % 4 == 0)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                continue;
            }
        }


    }
}