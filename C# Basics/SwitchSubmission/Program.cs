using System;
namespace SwitchSubmission;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose the operation to be done from the list: \n+ \n- \n* \n/ \n% \n\nYour Choice: ");
        Char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                {
                    Console.WriteLine("Sum of two numbers: " + (num1 + num2));
                    break;
                }
            case '-':
                {
                    Console.WriteLine("Difference of two numbers: " + (num1 - num2));
                    break;
                }
            case '*':
                {
                    Console.WriteLine("Product of two numbers: " + (num1 * num2));
                    break;
                }
            case '/':
                {
                    Console.WriteLine("Quotient of two numbers: " + (num1 / num2));
                    break;
                }
            case '%':
                {
                    Console.WriteLine("Remainder of two numbers: " + (num1 % num2));
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid, choose from the given options.");
                    break;
                }
        }



    }
}
