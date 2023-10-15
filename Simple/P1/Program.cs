using System;

namespace P1;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine().ToLower();
        int i, count = 0;
        for (i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                count++;
            }
        }
        Console.WriteLine(count);

    }
}
