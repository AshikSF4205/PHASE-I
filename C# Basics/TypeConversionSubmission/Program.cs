using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subject1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subject2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark of subjec31: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Grade :");
        char grade = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter mobile number :");
        long phNo = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter Mail id :");
        string mailId = Console.ReadLine();
        long total = mark1 + mark2 + mark3;
        double avg = total / 3.0;
        Console.WriteLine("Trainee Details Are :");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Mobile:" + phNo);
        Console.WriteLine("Mark1: " + mark1);
        Console.WriteLine("Mark2: " + mark2);
        Console.WriteLine("Mark3: " + mark3);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Mail Id: " + mailId);

    }
}