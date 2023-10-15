using System;

namespace DoWhileLoopAssignment;

class Program 
{
    public static void Main(string [] args)
    {

        /**************************************************************************************************/

        // 1

        // int size = int.Parse(Console.ReadLine());

        // int[] arr = new int[size];

        // for (int i=0; i<size; i++)
        //     arr[i] = int.Parse(Console.ReadLine());

        // bool sort = true;

        // while (sort)
        // {
        //     sort = false;

        //     for (int i=0; i<arr.Length-1; i++)
        //     {
        //         if (arr[i+1]<arr[i])
        //         {
        //             int temp = arr[i+1];
        //             arr[i+1] = arr[i];
        //             arr[i] = temp;
        //             sort = true;
        //             break;
        //         }
        //     }
        // }

        // for (int i=0; i<arr.Length; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        /**************************************************************************************************/

        // 2

        // int size = int.Parse(Console.ReadLine());

        // int [,] arr1 = new int[size,size];
        // int [,] arr2 = new int[size,size];

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         arr1[i,j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         arr2[i,j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // int [,] result = new int[size,size];
        
        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         int sum = 0;
        //         for (int k=0; k<size; k++)
        //         {
        //             sum += arr1[i,k] * arr2[k,j];
        //         }
        //         result[i,j] = sum;
        //     }
        // }

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         Console.Write(result[i,j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        /**************************************************************************************************/

        // 3

        // int size = int.Parse(Console.ReadLine());

        // int [] arr = new int[size];

        // for (int i=0; i<size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // for (int i=size-1; i>=0; i--)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        /**************************************************************************************************/

        // 4

        // int size = int.Parse(Console.ReadLine());
        // int sum = 0;

        // int [] arr = new int[size];

        // for (int i=0; i<size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // foreach(int i in arr)
        // {
        //     sum += i;
        // }

        // Console.WriteLine(sum);

        /**************************************************************************************************/

        // 5

        // int size = int.Parse(Console.ReadLine());
        
        // int [] arr = new int[size];

        // for (int i=0; i<size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // int min = arr[0];
        // int max = arr[0];

        // for (int i=1; i<size; i++)
        // {
        //     if (arr[i] < min) min = arr[i];
        //     if (arr[i] > max) max = arr[i];
        // }

        // Console.WriteLine("Maximum Element : " + max);
        // Console.WriteLine("Minimum Element : " + min);

        /**************************************************************************************************/

        // 6

        // int col = int.Parse(Console.ReadLine());
        // int row = int.Parse(Console.ReadLine());

        // int [,] arr = new int[row,col];

        // for (int i=0; i<row; i++)
        // {
        //     for (int j=0; j<col; j++)
        //     {
        //         arr[i,j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i=0; i<col; i++)
        // {
        //     for (int j=0; j<row; j++)
        //     {
        //         Console.Write(arr[j, i] + " ");
        //     }
        //     Console.WriteLine();
        // }

        /****************************************c**********************************************************/

        // 7

        // int size = int.Parse(Console.ReadLine());

        // int [,] arr1 = new int[size,size];
        // int [,] arr2 = new int[size,size];

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         arr1[i,j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         arr2[i,j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i=0; i<size; i++)
        // {
        //     for (int j=0; j<size; j++)
        //     {
        //         Console.WriteLine(arr1[i,j] + arr2[i,j]);
        //     }
        // }

        /**************************************************************************************************/

        // 8

        // int [] arr = new int[3*3];

        // for (int i=0; i<3*3; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // for (int i=0; i<3; i++)
        // {
        //     for (int j=0; j<3; j++)
        //     {
        //         Console.Write(arr[i*3+j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        /**************************************************************************************************/

        // 9

        // int size = int.Parse(Console.ReadLine());
        // int k = int.Parse(Console.ReadLine());

        // int [] arr = new int[size];

        // bool check = false;

        // for (int i=0; i<size; i++)
        // {
        //     if (int.Parse(Console.ReadLine()) == k)
        //     {
        //         Console.WriteLine(i);
        //         check = true;
        //         break;
        //     }
        // }

        // if (!check) Console.WriteLine(-1);

        /**************************************************************************************************/

        // 10

        // int size = int.Parse(Console.ReadLine());

        // int [] arr = new int[size];

        // for (int i=0; i<size; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // Console.Write("Odd Numbers : ");

        // for (int i=0; i<size; i++)
        // {
        //     if (arr[i] % 2 == 1) Console.Write(arr[i]);
        // }

        // Console.Write("\nEven Numbers : ");

        // for (int i=0; i<size; i++)
        // {
        //     if (arr[i] % 2 == 0) Console.Write(arr[i]);
        // }
    }
}