using System;
namespace P2;
public class Program
{
    static string Day()
    {
        return "Have a nice day!";
    }
    static string Welcome(string name)
    {
        return $"Welcome {name}. Day()";
    }
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Console.WriteLine(Welcome(name));
    }
}
