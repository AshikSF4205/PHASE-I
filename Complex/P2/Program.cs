using System;
namespace P2;
class Program
{
    static String removeDuplicateCharacters(char[] str, int n)
    {
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int j;
            for (j = 0; j < i; j++)
            {
                if (str[i] == str[j]) break;
            }

            if (j == i)
            {
                str[index++] = str[i];
            }
        }
        char[] answer = new char[index];
        Array.Copy(str, answer, index);
        return String.Join("", answer);
    }

    public static void Main(String[] args)
    {

        string name = Console.ReadLine();
        char[] str = name.ToCharArray();
        int n = str.Length;
        Console.WriteLine(removeDuplicateCharacters(str, n));
    }
}



