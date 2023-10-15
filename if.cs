using System;

namespace IfLoopAssignment;

class Program 
{
    public static void Main(string [] args)
    {
        // 1

        // int mark = Convert.ToInt32(Console.ReadLine());

        // if ((mark>=0) && (mark<=100))
        // {
        //     if (mark>80)
        //     {
        //         Console.WriteLine("Grade A");
        //     }

        //     else if (mark>60)
        //     {
        //         Console.WriteLine("Grade B");
        //     }

        //     else if (mark>=36)
        //     {
        //         Console.WriteLine("Grade C");
        //     }

        //     else
        //     {
        //         Console.WriteLine("Grade D");
        //     }
        // }

        // else
        // {
        //     Console.WriteLine("Invalid Input");
        // }

        /**************************************************************************************************/
        
        // 2

        // int number = Convert.ToInt32(Console.ReadLine());

        // if(number==0)
        //     Console.WriteLine("zero");
            
        // else if (number==1)
        //     Console.WriteLine("one");

        // else if (number==2)
        //     Console.WriteLine("two");

        // else if (number==3)
        //     Console.WriteLine("three");

        // else if (number==4)
        //     Console.WriteLine("four");

        // else if (number==5)
        //     Console.WriteLine("five");

        // else if (number==6)
        //     Console.WriteLine("six");

        // else if (number==7)
        //     Console.WriteLine("seven");

        // else if (number==8)
        //     Console.WriteLine("eight");

        // else if (number==9)
        //     Console.WriteLine("nine");

        // else
        //     Console.WriteLine("number too big");

        /**************************************************************************************************/

        // 3

        // int speed = Convert.ToInt32(Console.ReadLine());

        // if (speed<=10)
        // {
        //     Console.WriteLine("slow");
        // }

        // else if ((speed>10) && (speed<=50))
        // {
        //     Console.WriteLine("average");
        // }

        // else if ((speed>50) && (speed<=150))
        // {
        //     Console.WriteLine("fast");
        // }

        // else if ((speed>150) && (speed<=1000))
        // {
        //     Console.WriteLine("ultra fast");
        // }

        // else
        // {
        //     Console.WriteLine("extremely fast");
        // }

        /**************************************************************************************************/
        
        // 4

        // int temp = int.Parse(Console.ReadLine());

        // if (temp<0)
        //     Console.WriteLine("Freezing weather");

        // else if ((temp>=0) && (temp<=10))
        //     Console.WriteLine("Very Cold weather");

        // else if ((temp>=11) && (temp<=20))
        //     Console.WriteLine("Cold weather");

        // else if ((temp>=21) && (temp<=30))
        //     Console.WriteLine("Normal in Temperature");

        // else if ((temp>=31) && (temp<=40))
        //     Console.WriteLine("Its Hot");

        // else
        //     Console.WriteLine("Its Very Hot");
        
        /**************************************************************************************************/

        // 5
        // int year = int.Parse(Console.ReadLine());

        // if (year % 100 == 0)
        // {
        //     if (year % 400 == 0)
        //     {
        //         Console.WriteLine($"{year} is a leap year.");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{year} is not a leap year.");
        //     }
        // }

        // else
        // {
        //     if (year % 4 == 0)
        //     {
        //         Console.WriteLine($"{year} is a leap year.");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{year} is not a leap year.");
        //     }
        // }

        /**************************************************************************************************/

        // 6
        // int value1 = int.Parse(Console.ReadLine());
        // int value2 = int.Parse(Console.ReadLine());
        // int value3 = int.Parse(Console.ReadLine());

        // if ((value1 > value2) && (value1 > value3))
        // {
        //     Console.WriteLine(value1);
        // }

        // else if (value2 > value3)
        // {
        //     Console.WriteLine(value2);
        // }

        // else
        // {
        //     Console.WriteLine(value3);
        // }

        /**************************************************************************************************/

        // 7

        // int value = int.Parse(Console.ReadLine());

        // if (((value>=10) && (value<=19)) || (value == 0) || (value == 100))
        // {
        //     if (value==0)
        //         Console.WriteLine("zero");

        //     else if (value==10)
        //         Console.WriteLine("ten");

        //     else if (value==11)
        //         Console.WriteLine("eleven");

        //     else if (value==12)
        //         Console.WriteLine("twelve");

        //     else if (value==13)
        //         Console.WriteLine("thirteen");

        //     else if (value==14)
        //         Console.WriteLine("fourteen");

        //     else if (value==15)
        //         Console.WriteLine("fifteen");

        //     else if (value==16)
        //         Console.WriteLine("sixteen");

        //     else if (value==17)
        //         Console.WriteLine("seventeen");

        //     else if (value==18)
        //         Console.WriteLine("eighteen");

        //     else if (value==19)
        //         Console.WriteLine("nineteen");

        //     else if (value==100)
        //         Console.WriteLine("hundred");
        // }



        // else
        // {
        //     string front = "";
        //     string back = "";

        //     if (value/10==2)
        //         front = "twenty";

        //     else if (value/10==3)
        //         front = "thirty";

        //     else if (value/10==4)
        //         front = "forty";

        //     else if (value/10==5)
        //         front = "fifty";

        //     else if (value/10==6)
        //         front = "sixty";

        //     else if (value/10==7)
        //         front = "seventy";

        //     else if (value/10==8)
        //         front = "eighty";

        //     else if (value/10==9)
        //         front = "ninety";



        //     if (value % 10 == 1)
        //         back = "one";

        //     else if (value % 10 == 2)
        //         back = "two";

        //     else if (value % 10 == 3)
        //         back = "three";

        //     else if (value % 10 == 4)
        //         back = "four";

        //     else if (value % 10 == 5)
        //         back = "five";

        //     else if (value % 10 == 6)
        //         back = "six";

        //     else if (value % 10 == 7)
        //         back = "seven";

        //     else if (value % 10 == 8)
        //         back = "eight";

        //     else
        //         back = "nine";

        //     Console.Write(front);

        //     if (value>=20)
        //         Console.Write(" ");

        //     Console.Write(back);

        // }

        /**************************************************************************************************/
        
        // 8

        // int N = int.Parse(Console.ReadLine());
        // int L = int.Parse(Console.ReadLine());
        // int R = int.Parse(Console.ReadLine());

        // if (((N>L) && (N<R)) || (N<L) && (N>R))
        //     Console.WriteLine("yes");
        // else
        //     Console.WriteLine("no");

        /**************************************************************************************************/

        // 9

        // int N = int.Parse(Console.ReadLine());
        // int M = int.Parse(Console.ReadLine());

        // if ((N+M)%2==0)
        //     Console.WriteLine("Even");
        // else
        //     Console.WriteLine("Odd");

        /**************************************************************************************************/

        // 10

        // int value1 = int.Parse(Console.ReadLine());
        // int value2 = int.Parse(Console.ReadLine());
        // int value3 = int.Parse(Console.ReadLine());

        // if ((value1 + value2 > value3) && (value2 + value3 > value1) && (value1 + value3 > value2))
        //     Console.WriteLine("yes");
        // else
        //     Console.Write("no");

        /**************************************************************************************************/

        // 11

        // char c1 = char.Parse(Console.ReadLine());
        // char c2 = char.Parse(Console.ReadLine());

        // if (c1 == c2) Console.WriteLine("Winner: D");
        // else if ((c1=='P' && c2=='R') || (c1=='R' && c2=='S') || (c1=='S' && c2=='P') || (c1=='P' && c2=='S') || (c1=='R' && c2=='P') || (c1=='S' && c2=='R')) Console.WriteLine("Winner: " + c1);
    
    }
}