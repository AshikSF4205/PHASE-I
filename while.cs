using System;

namespace WhileLoopAssignment;

class Program 
{
    public static void Main(string [] args)
    {

        /**************************************************************************************************/
        
        // 1

        // int input1 = int.Parse(Console.ReadLine());
        // int input2 = int.Parse(Console.ReadLine());

        // int ans = -1;
        // int min;

        // if (input1<=input2)
        //     min = input1;
        // else
        //     min = input2;

        // int i=1;
        // while (i<=min)
        // {
        //     if (input1%i==0)
        //     {
        //         if (input2%i==0)
        //         {
        //             ans = i;
        //         }
        //     }
        //     i++;
        // }

        // Console.WriteLine(ans);

        /**************************************************************************************************/
        
        // 2
        // long number = long.Parse(Console.ReadLine());
        // long limit = long.Parse(Console.ReadLine());

        // bool check = true;

        // while ((number>0) && (check))
        // {
        //     if (!(number%10<=limit))
        //         check = false;
        //     number/=10;
        //     Console.WriteLine(number);
        // }

        // if (check)
        //     Console.WriteLine("yes");
        // else
        //     Console.WriteLine("no");

        /**************************************************************************************************/

        // 3
        // int input = int.Parse(Console.ReadLine());

        // int ans = 2;

        // while (ans<=input)
        // {
        //     ans *= 2;
        // }

        // Console.WriteLine(ans);

        /**************************************************************************************************/

        // 4
        // int input = int.Parse(Console.ReadLine());

        // int multiple = 1;

        // while (multiple*5<input)
        // {
        //     int number = multiple*5;
        //     if (multiple%2 == 0)
        //     {
        //         Console.WriteLine(number);
        //     }
        //     multiple++;
        // }

        /**************************************************************************************************/

        // 5
        // int input = int.Parse(Console.ReadLine());
        // int ans = 0;

        // while (input>0)
        // {
        //     ans = (ans*10) + (input%10);
        //     input/=10;
        // }
        // Console.WriteLine(ans);

        /**************************************************************************************************/

        // 6

        // int input = int.Parse(Console.ReadLine());

        // int num1 = 0;
        // int num2 = 1;

        // int track = 2;

        // Console.WriteLine(num1);
        // if (input > 1)
        // {
        //     Console.WriteLine(num2);

        //     if (input>2)
        //     {

        //         while (track<input)
        //         {
        //             int temp = num1;
        //             num1 = num2;
        //             num2 = temp + num2;
        //             Console.WriteLine(num2);
        //             track++;
        //         }
        //     }
        // }


        /**************************************************************************************************/

        // 7

        // int input = int.Parse(Console.ReadLine());
        
        // int ans = 0;

        // while (input>0)
        // {
        //     ans += input % 10;
        //     input /= 10;
        // }
        
        // Console.WriteLine(ans);
        
        /**************************************************************************************************/

        // 8

        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());

        // int min;

        // if (num1<num2) min = num1;
        // else min = num2;

        // int i = 1;
        // int ans = 1;

        // while (i<=min)
        // {
        //     if ((num1%i==0) && (num2%i==0)) ans = i;
        //     i++;
        // }

        // Console.WriteLine(ans);

        /**************************************************************************************************/

        // 9

        // int num = int.Parse(Console.ReadLine());

        // int ans = 0;
        // int temp;

        // while (num>0)
        // {
        //     temp = (num%10)%2;
        //     if (temp == 1) ans += temp;
        //     num/=10;
        // }

        // if (ans%2==0) Console.WriteLine("even");
        // else Console.WriteLine("odd");

        /**************************************************************************************************/

        // 10

        // int input = int.Parse(Console.ReadLine());

        // int count = 3;
        // input++;

        // while (count>0)
        // {
        //     bool prime = true;

        //     for (int i=2; i<=input/2;i++)
        //     {
        //         if  (input%i==0)
        //         {
        //             prime = false;
        //             break;
        //         }
        //     }

        //     if (prime && input>1)
        //     {
        //         Console.WriteLine(input);
        //         count--;
        //     }

        //     input++;
        // }
    }
}