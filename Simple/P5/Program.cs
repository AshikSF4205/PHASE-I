using System;
namespace P3;
public class Program
{
    public static void Main(string[] args)
    {
        string phrase = "s3cr3t!P@ssw0rd";
        string password = Console.ReadLine();
        bool flag = false;

        if(phrase.Length == password.Length){
            for(int i =0; i<phrase.Length; i++){
                if(phrase[i]==password[i]){
                    flag = true;
                }
                else{
                    flag = false;
                    break;
                }
            }
            if(flag) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
        else{
            Console.WriteLine("Wrong password!");
        }
        
    }
}