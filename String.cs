// using System;
// namespace String;

// class Program{
//     public static void Main(string[] args)
//     {
//     //     string input;
//     //     input=Console.ReadLine();
//     //    int count=0;
//     //    foreach(char i in input){
//     //         count++;
//     //    }
//     //    Console.WriteLine(count); 2


//         // string input=Console.ReadLine();
//         // int count=1;
//         // foreach(char c in input){
//         //     if(c==' '){
//         //         count++;
//         //     }
//         // }
//         // Console.WriteLine(count); 4


//         // string sentence=Console.ReadLine();
//         // string word=Console.ReadLine();
//         // string search=Console.ReadLine();
//         // string[] strArray=sentence.Split(" ");
//         // string[] output=new string[strArray.Length+1];
//         // for(int i=0;i<strArray.Length;i++){
//         //         if(strArray[i]!=search){
//         //             output[i]=strArray[i];
//         //         }
//         // }

//         // string input=Console.ReadLine();
//         // int vowelCount=0;
//         // int consoCount=0;
//         // foreach(char i in input){
//         //     if(i=='A'||i=='E'||i=='I'|| i=='O' || i=='U' || i=='a'||i=='e'||i=='i'|| i=='o' || i=='u'){
//         //             vowelCount++;
//         //     }
//         //     else{
//         //         consoCount++;
//         //     }
//         // }
//         // Console.WriteLine("Total number of vowels: "+vowelCount);
//         // Console.WriteLine("Total number of consonants: "+consoCount);

//         // string input=Console.ReadLine();
//         // int weight=0;
//         // foreach(char characters in input){
//         //     int temp=(int) characters;
//         //     weight+=temp;
//         // }
//         // System.Console.WriteLine(weight); 9


//         // string input=Console.ReadLine().ToUpper();
//         // string output="";
//         // for(int i=input.Length-1;i>=0;i--){
//         //     output+=input[i];
//         // }
//         // System.Console.WriteLine(output);


//         string input1=Console.ReadLine();
//         string input2=Console.ReadLine();
//         string[] array1=input1.Split(" ");
//         string[] array2=input2.Split(" ");
//         string compare1=array1[1];
//         string compare2=array2[1];
//         if((int)compare1[0]<=(int)compare2[0] ){
//                 System.Console.WriteLine(input1+"\n"+input2);
//         }
//         else{
//             System.Console.WriteLine(input2+"\n"+input1);
//         }

//     }
// }

using System;

public class Program
{
    static void Chars(string input,out int vowel,out int consonant){
        vowel=0;
        consonant=0;
        foreach(char ch in input){
            if(char.IsLetter(ch)){
                if("aeiouAEIOU".Contains(ch)){
                    vowel++;
                }
                else{
                    consonant++;
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        string input=Console.ReadLine();
        int vowel,consonant;
        Chars(input,out vowel,out consonant);
        Console.WriteLine("Total number of vowels: "+vowel);
        Console.WriteLine("Total number of consonants: "+consonant);
    }
}