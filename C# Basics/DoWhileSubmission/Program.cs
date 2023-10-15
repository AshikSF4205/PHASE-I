using System;
namespace WhileSubmission;
class Program
{
    public static void Main(string[] args)
    {
        string choice = string.Empty;
        do
        {

            System.Console.WriteLine("Enter the number to be checked:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine("It is a even number");
            }
            else
            {
                System.Console.WriteLine("It is a odd number");
            }

            System.Console.WriteLine("Do u wanna test another number, choose Yes or No?");
            choice = Console.ReadLine().ToLower();
            while (choice != "yes" && choice != "no") ;
            {
                System.Console.WriteLine("Your input is wrong, choose Yes or No?");
                choice = Console.ReadLine().ToLower();
            }

        } while (choice == "yes");

    }
}