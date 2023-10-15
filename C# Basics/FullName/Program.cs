using System;
namespace FullName
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Father's Name:");
            string fatherName = Console.ReadLine();
            //Concationation
            Console.WriteLine("My Full Name is "+ name +" "+ fatherName);
            //Placeholder
            Console.WriteLine("My Full Name is {0} {1}", name, fatherName);
            //Interpolation
            Console.WriteLine($"My Full Name is {name} {fatherName}");
            
        }
    }
}