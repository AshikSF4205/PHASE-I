
/*
Input Data The input data comes as 5 numbers, which are read from the console:

N – length of a side of the ground within the range of [1 … 100].

W – width per tile within the range of [0.1 … 10.00].

L – length per tile within the range of [0.1 … 10.00].

М – width of the bench within the range of [0 … 10].

О – length of the bench within the range of [0 … 10].

Output Data The number of tiles needed for the repair and the total time for changing them, can be returned as out parameters.
*/

using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {

        int sideOfGround = Convert.ToInt32(Console.ReadLine());
        double widthOfTile = Convert.ToDouble(Console.ReadLine());
        double lengthOfTile = Convert.ToDouble(Console.ReadLine());
        int widthOfBench = Convert.ToInt32(Console.ReadLine());
        int lengthOfBench = Convert.ToInt32(Console.ReadLine());

        int areaOfGround = sideOfGround * sideOfGround;
        int areaOfBench = widthOfBench * lengthOfBench;
        double areaOfTile = widthOfTile * lengthOfTile;

        int areaToBeRepaired = areaOfGround - areaOfBench;

        Console.WriteLine("Number of tiles needed " + Math.Round((areaToBeRepaired / areaOfTile), 2));
        Console.WriteLine("Number of tiles needed " + Math.Round(((areaToBeRepaired / areaOfTile) * 0.2), 1));


    }

}