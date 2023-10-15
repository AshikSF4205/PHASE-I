using System;
namespace ArraySubmission;
class Program
{
    public static void Main(string[] args)
    {
        string[] nameArray = new string[5];
        nameArray[0] = "Mani";
        nameArray[1] = "Ashik";
        nameArray[2] = "Ganesh";
        nameArray[3] = "Suresh";
        nameArray[4] = "Venkat";


        foreach (string name in nameArray)
        {
            System.Console.WriteLine(name);
        }

        System.Console.WriteLine("\nEnter the name to be searched:");
        string nameToBeSearched = Console.ReadLine();

        System.Console.WriteLine("\n\nSEARCH IN FOR LOOP");
        for (int i = 0; i < nameArray.Length; i++)
        {
            if (nameToBeSearched.Equals(nameArray[i]))
            {
                System.Console.WriteLine("The name is present in array\nAnd the index is " + i);
                break;
            }
            if (i == nameArray.Length - 1)
            {
                System.Console.WriteLine("The name is not present in array");
            }

        }

        System.Console.WriteLine("\n\nSEARCH IN FOR EACH LOOP");
        bool flag = false;
        foreach (string name in nameArray)
        {
            if (nameToBeSearched.Equals(name))
            {
                System.Console.WriteLine("The name is present in array");
                flag = false;
                break;
            }
            else
            {
                flag = true;
            }
        }
        if (flag) System.Console.WriteLine("The name is not present in array");

    }
}

