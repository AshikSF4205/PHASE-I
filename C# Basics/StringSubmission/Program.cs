using System;
namespace StringSubmission;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Long main String: ");
        string longString = Console.ReadLine();
        Console.Write("Enter the Short String: ");
        string shortString = Console.ReadLine();

        int freq = 0;

        int index = longString.IndexOf(shortString);
        while (index >= 0)
        {
            index = longString.IndexOf(shortString, index + shortString.Length);
            freq++;
        }
        Console.Write("String search count is " + freq);
    }


}
