using System;

namespace DoWhileLoopAssignment;

class Program 
{
    public static void Main(string [] args)
    {
        // 1

        // int number;
        // bool check = int.TryParse(Console.ReadLine(),out number);
        // int remainder = number % 2;


        // if (check)
        // {
        //     switch (remainder)
        //     {
        //         case 0:
        //         {
        //             Console.WriteLine("Even Number");
        //             break;
        //         }

        //         case 1:
        //         {
        //             Console.WriteLine("Odd Number");
        //             break;
        //         }
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Invalid Input");
        // }

        /**************************************************************************************************/

        // 2

        // int month;
        // bool check = int.TryParse(Console.ReadLine(),out month);

        // int year;
        // bool temp = int.TryParse(Console.ReadLine(),out year);
        
        // if ((check) && (temp))
        // {
        //     if ((month>0) && (month<=12))
        //     {
        //         switch (month)
        //         {
        //             case 1:
        //             case 3:
        //             case 5:
        //             case 7:
        //             case 8:
        //             case 10:
        //             case 12:
        //             {
        //                 Console.WriteLine(31);
        //                 break;
        //             }

        //             case 4:
        //             case 6:
        //             case 9:
        //             case 11:
        //             {
        //                 Console.WriteLine(30);
        //                 break;
        //             }

        //             case 2:
        //             {
        //                 if (year%100 == 0)
        //                 {
        //                     if (year%400 == 0)
        //                     {
        //                         Console.WriteLine(29);
        //                     }
        //                 }
                        
        //                 else if (year%4 == 0)
        //                 {
        //                     Console.WriteLine(29);
        //                 }

        //                 else
        //                 {
        //                     Console.WriteLine(28);
        //                 }
        //                 break;
        //             }
        //         }

        //     }
        //     else
        //     {
        //         Console.WriteLine(0);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine(0);
        // }

        /**************************************************************************************************/

        // 3

        // string input = Console.ReadLine();

        // switch(input)
        // {
        //     case "a":
        //     case "A":
        //     case "e":
        //     case "E":
        //     case "i":
        //     case "I":
        //     case "o":
        //     case "O":
        //     case "u":
        //     case "U":
        //     {
        //         Console.WriteLine("The alphabet is a vowel.");
        //         break;
        //     }
        //     default:
        //     {
        //         Console.WriteLine("The alphabet is not a vowel.");
        //         break;
        //     }
        // }

        /**************************************************************************************************/

        // 4

        // int input = int.Parse(Console.ReadLine());

        // switch (input)
        // {
        //     case 1:
        //     {
        //         Console.WriteLine("Sunday");
        //         break;
        //     }

        //     case 2:
        //     {
        //         Console.WriteLine("Monday");
        //         break;
        //     }

        //     case 3:
        //     {
        //         Console.WriteLine("Tuesday");
        //         break;
        //     }

        //     case 4:
        //     {
        //         Console.WriteLine("Wednesday");
        //         break;
        //     }

        //     case 5:
        //     {
        //         Console.WriteLine("Thursday");
        //         break;
        //     }

        //     case 6:
        //     {
        //         Console.WriteLine("Friday");
        //         break;
        //     }

        //     case 7:
        //     {
        //         Console.WriteLine("Saturday");
        //         break;
        //     }

        //     default:
        //     {
        //         Console.WriteLine("Invalid number");
        //         break;
        //     }
        // }

        /**************************************************************************************************/

        // 5

        // string input = Console.ReadLine();

        // input = input.ToUpper();

        // switch (input)
        // {
        //     case "DECEMBER": case "JANUARY": case "FEBRUARY":
        //     {
        //         Console.WriteLine("Winter");
        //         break;
        //     }

        //     case "MARCH": case "APRIL": case "MAY":
        //     {
        //         Console.WriteLine("Spring");
        //         break;
        //     }

        //     case "JUNE": case "JULY": case "AUGUST":
        //     {
        //         Console.WriteLine("Summer");
        //         break;
        //     }

        //     case "SEPTEMBER": case "OCTOBER": case "NOVEMBER":
        //     {
        //         Console.WriteLine("Rainfall");
        //         break;
        //     }

        //     default:
        //     {
        //         Console.WriteLine("Unknown");
        //         break;
        //     }
        // }

        /**************************************************************************************************/

        // 6

        // char c = char.Parse(Console.ReadLine());

        // switch (c)
        // {
        //     case >= 'A' and <= 'Z':
        //         Console.WriteLine("The character is an uppercase character.");
        //         break;

        //     case >= 'a' and <= 'z':
        //         Console.WriteLine("The character is a lowercase character.");
        //         break;

        //     default:
        //         Console.WriteLine("The character is not an alphabet");
        //         break;
        // }

        /**************************************************************************************************/

        // 7

        // char c = char.Parse(Console.ReadLine());

        // switch (char.ToLower(c))
        // {
        //     case >='a' and <= 'z':
        //         Console.WriteLine("The character is an alphabet.");
        //         break;

        //     case >= '0' and <= '9':
        //         Console.WriteLine("The character is a digit.");
        //         break;

        //     default:
        //         Console.WriteLine("The character is a special character.");
        //         break;
        // }

        /**************************************************************************************************/

        // 8

        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        
        // int choice = int.Parse(Console.ReadLine());

        // switch (choice)
        // {
        //     case 1:
        //         Console.WriteLine(num1+num2);
        //         break;

        //     case 2:
        //         Console.WriteLine(num1-num2);
        //         break;

        //     case 3:
        //         Console.WriteLine(num1*num2);
        //         break;

        //     case 4:
        //         Console.WriteLine(num1/num2);
        //         break;
        // }

        /**************************************************************************************************/

        // 9

        // char c = char.Parse(Console.ReadLine());

        // switch (c)
        // {
        //     case 'E':
        //         Console.WriteLine("Excellent");
        //         break;

        //     case 'V':
        //         Console.WriteLine("Very Good");
        //         break;

        //     case 'G':
        //         Console.WriteLine("Good");
        //         break;

        //     case 'A':
        //         Console.WriteLine("Average");
        //         break;

        //     case 'F':
        //         Console.WriteLine("Fail");
        //         break;

        //     default:
        //         Console.WriteLine("Invalid Grade");
        //         break;
        // }
        
        /**************************************************************************************************/

        // 10

        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());

        // int sum = num1-num2;

        // switch (sum)
        // {
        //     case >0:
        //         Console.WriteLine(num1);
        //         break;

        //     case <0:
        //         Console.WriteLine(num2);
        //         break;

        //     case 0:
        //         Console.WriteLine("Numbers are equal");
        //         break;
        // }
    }
}