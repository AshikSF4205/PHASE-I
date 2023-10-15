using System;
namespace DateTimeSubmission;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021, 8, 10, 10, 40, 32);

        System.Console.WriteLine($"{date.Year} \n {date.Month} \n {date.Day} \n {date.Hour} \n {date.Minute} \n {date.Second}");

        string strDate = date.ToString("yyyy/MM/dd hh:mm:ss tt");
        System.Console.WriteLine(strDate + "\n");

        string[] strDateArray = strDate.Split(':', '/', ' ');
        System.Console.WriteLine("\nString date - Reverse:");

        for (int i = strDateArray.Length - 1; i >= 0; i--)
        {
            System.Console.Write(strDateArray[i] + " ");
        }

        System.Console.WriteLine("\nEnter the Date and Time (Format: yyyy/MM/dd hh:mm:ss tt): ");
        string fullDate = Console.ReadLine();


        DateTime result = DateTime.ParseExact(fullDate, "yyyy/MM/dd hh:mm:ss tt", null);

        System.Console.WriteLine($"{result.Year} \n {result.Month} \n {result.Day}");


    }
}