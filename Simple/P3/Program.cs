using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {
        int currency = Convert.ToInt32(Console.ReadLine());

        double usd = (currency * 1.22) / 100;
        Console.WriteLine($"{Math.Round(usd, 4)} USD");
        double eur = (currency * 1.27) / 100;
        Console.WriteLine($"{Math.Round(eur, 4)} EUR");
        double cny = (currency * 8.79) / 100;
        Console.WriteLine($"{Math.Round(cny, 4)} CNY");

    }
}
