using System;
namespace P1;
class Program
{
    public static void Main(string[] args)
    {
        int i, j, m, n;

        m = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[m, n];
        //Enter the First Matrix
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }


        int[,] b = new int[n, m];
        //Enter the Second Matrix
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }


        //Matrix Multiplication is
        int[,] c = new int[m, m];
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < m; j++)
            {
                c[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < m; j++)
            {
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
