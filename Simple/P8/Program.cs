using System;
namespace P8;
class Program
{
    public static void Main(string[] args)
    {
        char letter = char.Parse(Console.ReadLine());
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
        {
            System.Console.WriteLine("It is a vowel.");
        }
        else
        {
            System.Console.WriteLine("It is not a vowel.");
        }

    }
}
