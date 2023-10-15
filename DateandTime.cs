using System;
using System.Globalization;
namespace DateandTime;

class Program{
    public static void Main(string[] args)
    {
        // int month=Convert.ToInt32(Console.ReadLine());
        // int year=Convert.ToInt32(Console.ReadLine());
        // int noDays=DateTime.DaysInMonth(year,month);
        // Console.WriteLine(noDays);

        // 2016/08/16 03:57:32.011
        
        // DateTime userDate=new DateTime();
        // userDate=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd HH:mm:ss.fff",null,System.Globalization.DateTimeStyles.None);
        // Console.WriteLine("year = "+userDate.Year);
        // Console.WriteLine("month = "+userDate.Month);
        // Console.WriteLine("day = "+userDate.Day);
        // Console.WriteLine("hour = "+userDate.Hour);
        // Console.WriteLine("minute = "+userDate.Minute);
        // Console.WriteLine("second = "+userDate.Second);
        // Console.WriteLine("millisecond = "+userDate.Millisecond);

        // DateTime userDate=new DateTime();
        // userDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None);
        // DateTime currentDay=new DateTime();
        // currentDay=userDate.AddDays(40);
        // Console.WriteLine("Date : "+currentDay.ToString("dd/MM/yyyy"));
        // Console.WriteLine("Day : "+currentDay.DayOfWeek);


        // DateTime userDate=new DateTime();
        // userDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None);
        // DateTime currentDay=new DateTime();
        // DateTime pastDay=new DateTime();
        // currentDay=userDate.AddYears(15);
        // pastDay=userDate.AddYears(-15);
        // Console.WriteLine("15 years before date is: "+pastDay);
        // Console.WriteLine("After the date is: "+currentDay);


        // DateTime userDate1=new DateTime();
        // userDate1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None);
        // DateTime userDate2=new DateTime();
        // userDate2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None);
        // TimeSpan difference= userDate1 -userDate2;
        // int days=difference.Days;
        // if(days==0){
        //     Console.WriteLine("Today");
        // }
        // else if(days<0){
        //     Console.WriteLine("Past");
        // }
        // else{
        //     Console.WriteLine("Future");
        // }

        // int year1=Convert.ToInt32(Console.ReadLine());
        // int year2=Convert.ToInt32(Console.ReadLine());
        // for(int i=year1;i<=year2;i++){
        //     if(DateTime.IsLeapYear(i)){
        //         Console.WriteLine(i);
        //     }
        // }

    //     int month=Convert.ToInt32(Console.ReadLine());
    //     int year=Convert.ToInt32(Console.ReadLine());
    //     int noDays=DateTime.DaysInMonth(year,month);
    //     Console.WriteLine(noDays*500);
    // }

        int row=Convert.ToInt32(Console.ReadLine());
        int col=Convert.ToInt32(Console.ReadLine());
        int[,] matrix1=new int[row,col];
        int[,] matrix2=new int[row,col];
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                matrix1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                    matrix2[j,i]=matrix1[i,j];
            }
        }

        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
               Console.Write(matrix2[i,j]+" ");
            }
            Console.WriteLine();
        }
    }

}