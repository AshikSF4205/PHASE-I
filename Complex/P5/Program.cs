using System;

namespace P4;

public class Program
{
    public static void Main(string[] args)
    {
        string string1 = Console.ReadLine();
        string string2 = Console.ReadLine();

        if (string1.Length == string2.Length)
        {
            bool flag = false;
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = 0; i < string1.Length; i++)
                {
                    if (string1[i] == string2[j])
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if (flag)
            {
                System.Console.WriteLine("Anagrams");
            }
            else
            {
                System.Console.WriteLine("Not Anagrams");
            }
        }
        else
        {
            System.Console.WriteLine("Not Anagrams");
        }
    }
}
