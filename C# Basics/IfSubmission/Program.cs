using System;
namespace IfSubmission;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter mark:");
        int mark = int.Parse(Console.ReadLine());
        if (mark > 100 || mark < 0)
        {
            System.Console.WriteLine("Invalid Input");
        }
        else if (mark > 80)
        {
            System.Console.WriteLine("Grade A");
        }
        else if (mark > 60)
        {
            System.Console.WriteLine("Grade B");
        }
        else if (mark >= 36)
        {
            System.Console.WriteLine("Grade C");
        }
        else if (mark >= 0)
        {
            System.Console.WriteLine("Grade D");
        }
    }
}
