using System;
namespace WhileSubmission;
class Program
{
    static double Add(double number1, double number2)
    {
        return number1 + number2;
    }
    static double Subtract(double number1, double number2)
    {
        return number1 - number2;
    }
    static double Multiply(double number1, double number2)
    {
        return number1 * number2;
    }
    static double Divide(double number1, double number2)
    {
        return number1 / number2;
    }
    public static void Main(string[] args)
    {
        string choice = string.Empty;
        bool temp1 = false, temp2 = false;
        double number1, number2;
        do
        {
            do
            {
                Console.WriteLine("Enter two valid numbers:");
                temp1 = double.TryParse(Console.ReadLine(), out number1);
                temp2 = double.TryParse(Console.ReadLine(), out number2);

            } while (!(temp1 & temp2));

            bool flag = true;
            do
            {
                Console.WriteLine("Choose the operation to be done from the list: \n+ \n- \n* \n/ \n\nYour Choice: ");
                Char operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        {
                            Console.WriteLine("Sum of two numbers: " + Add(number1, number2));
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Subtraction of number 1 minus number 2: " + Subtract(number1, number2));
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("Product of two numbers: " + Multiply(number1, number2));
                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine("Divison of number 1 by number 2: " + Divide(number1, number2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid, choose from the given options.");
                            flag = false;
                            break;
                        }
                }
            } while (!flag);



            System.Console.WriteLine("Do you want do another operation, choose Yes or No?");
            choice = Console.ReadLine().ToLower();
            while (choice != "yes" && choice != "no")
            {
                System.Console.WriteLine("Your input is wrong, choose Yes or No?");
                choice = Console.ReadLine().ToLower();
            }

        } while (choice == "yes");

    }
}