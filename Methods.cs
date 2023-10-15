using System;
namespace Methods;
public class Program
{
//     // static bool PrimeCheck(int input){
//     //     if(input==0 || input==1){
//     //         return false;
//     //     }
//     //     else{
//     //         for(int i=2;i<input/2;i++){
//     //             if(input%i==0){
//     //                 return false;
                    
//     //             }
//     //         }
//     //     }
//     //   return true;
//     // }
//     // public static void Main(string[] args)
//     {
//        int input=Convert.ToInt32(Console.ReadLine());
//        if(PrimeCheck(input)){
//             Console.WriteLine("yes");
//        }
//        else{
//         Console.WriteLine("no");
//        }
//     }
// }
        // static void SwapNumbers(int input1,int input2){
        //     int temp=input1;
        //     input1=input2;
        //     input2=temp;
        //     Console.WriteLine("First Number : "+input1);
        //     Console.WriteLine("Second Number : "+input2);
        // }

    //     static double Percentage(int input1,int input2,int input3){
    //         int sum=input1+input2+input3;
    //         double percent=(double)sum*100/300;
    //         return percent;
    //     }
    //     static int FindMax(int input1,int input2,int input3){
    //         if(input1>input2 && input1>input3){
    //             return input1;
    //         }
    //         else if(input2>input1 && input2>input3){
    //             return input2;
    //         }
    //         else{
    //             return input3;
    //         }
    //     }
    // public static void Main(string[] args)
    // {
    //     int input1=Convert.ToInt32(Console.ReadLine());
    //     int input2=Convert.ToInt32(Console.ReadLine());
    //     int input3=Convert.ToInt32(Console.ReadLine());
    //     double percent= Percentage(input1,input2,input3);
    //     int maximum=FindMax(input1,input2,input3);
    //     Console.WriteLine(percent);
    //     Console.WriteLine(maximum);
        
    // } 3


    // static int Counter(string input){
    //     int count=0;
    //     foreach(char i in input){
    //         if(i==' '){
    //             count++;
    //         }
    //     }
    //     return count;
    // }
    // public static void Main(string[] args)
    // {
    //     string input=Console.ReadLine();
    //     int spaceCount=Counter(input);
    //     System.Console.WriteLine(spaceCount);
    // } 4


    // static int Add(int[] array){
    //     int sum=0;
    //     foreach(int numbers in array){
    //         sum+=numbers;
    //     }
    //     return sum;
    // }
    // public static void Main(string[] args)
    // {
    //     int size=Convert.ToInt32(Console.ReadLine());
    //     int[] array=new int[size];
    //     for(int i=0;i<size;i++){
    //         array[i]=Convert.ToInt32(Console.ReadLine());
    //     }
    //     int sum=Add(array);
    //     System.Console.WriteLine(sum);
    // } 5

    // static int Add(int input1,int input2){
    //     return input1+input2;
    // }
    // public static void Main(string[] args)
    // {
    //     int input1=Convert.ToInt32(Console.ReadLine());
    //     int input2=Convert.ToInt32(Console.ReadLine());
    //     int output=Add(input1,input2);
    //     Console.WriteLine(output);
    // } 6

    // static double Addition(double number1,double number2){
    //     return number1 + number2;
    // }
    // static double Subraction(double number1,double number2){
    //     return number1 - number2;
    // }
    // static double Multiplication(double number1,double number2){
    //     return number1 * number2;
    // }
    // static double Division(double number1,double number2){
    //     return number1 / number2;
    // }

    // private static double Calculation(double input1,double input2,char operation){
    //     switch(operation){
    //         case '+':{
    //             return Addition(input1,input2);
    //         }
    //         case '-':{
    //             return Subraction(input1,input2);
    //         }
    //         case '*':{
    //             return Multiplication(input1,input2);
    //         }
    //         case '/':{
    //             return Division(input1,input2);
    //         }
    //         default:{
    //             return 0;
    //         }
    //     }
    // }
    //  public static void Main(string[] args)
    // {
    //     double input1=Convert.ToDouble(Console.ReadLine());
    //     double input2=Convert.ToDouble(Console.ReadLine());
    //     char operation=Convert.ToChar(Console.ReadLine());
    //     double result=Calculation(input1,input2,operation);
    //     System.Console.WriteLine(result);
    // }

    static int FindDigit(int input1,int input2){
        int count=0;
        while(input1>0){
            int r=input1%10;
            if(count+1==input2){
                return r;
            }
            input1/=10;
            count++;
        }
        return 0;
    }
    public static void Main(string[] args)
    {
   int input1=Convert.ToInt32(Console.ReadLine());
    int input2=Convert.ToInt32(Console.ReadLine());
    int output=FindDigit(input1,input2);
    Console.Write(output);
    }
}