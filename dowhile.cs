using System;

namespace DoWhileLoopAssignment;

class Program 
{
    public static void Main(string [] args)
    {

        /**************************************************************************************************/

        // 1

        // int input = int.Parse(Console.ReadLine());

        // int i = 1;

        // do
        // {
        //     for (int j=0; j<(input-i)*2; j++)
        //         Console.Write(" ");

        //     for (int j=1; j<=i*2-1; j++)
        //         Console.Write(i);

        //     Console.WriteLine();
            
        //     i++;
        // } while (i<=input);

        /**************************************************************************************************/

        // 2

        // int input = int.Parse(Console.ReadLine());

        // int sum = 0;

        // do
        // {
        //     sum += input%10;
        //     input/=10;
        // } while (input>0);

        // Console.WriteLine(sum);

        /**************************************************************************************************/

        // 3

        // double input = double.Parse(Console.ReadLine());

        // double ans = 0;
        // double num = 1;

        // do
        // {
        //     ans += 1/num;
        //     num++;
        // } while (num<=input);

        // Console.WriteLine(ans);

        /**************************************************************************************************/

        // 4

        // int input = int.Parse(Console.ReadLine());

        // int ans = 0;

        // do
        // {
        //     ans = ans*10 + input%10;
        //     input/=10;
        // } while (input>0);

        // Console.WriteLine(ans);

        /**************************************************************************************************/

        // 5

        // int input = int.Parse(Console.ReadLine());
        // int i = 1;
        
        // do {
        //     int number = i; 
        //     int digit = 0;
            
        //     do
        //     {
        //         number/=10;
        //         digit++;
        //     } while (number>0);

        //     int ans = 0;
        //     number = i;

        //     do
        //     {
        //         int sum = 1;
        //         int j=0;

        //         do
        //         {
        //             sum *= (number%10);
        //             j++;
        //         } while(j<digit);

        //         ans+= sum;
        //         number/=10;
        //     } while (number > 0);

        //     if(ans == i)
        //         Console.WriteLine(i);

        //     i++;
        // } while (i<input);

        /**************************************************************************************************/

        // 6

        // int input = int.Parse(Console.ReadLine());
        // int power = int.Parse(Console.ReadLine());

        // int i = 1;
        // int num = input;

        // do
        // {
        //     input *= num;
        //     i++;
        // } while (i<power);

        // Console.WriteLine(input);
    }
}