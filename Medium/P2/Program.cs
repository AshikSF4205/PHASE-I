using System;
namespace P2;
public class Program
{
    public static void Main(string[] args)
    {


        double salary = Convert.ToDouble(Console.ReadLine());

        double da, hra, netPay, annualGrossSalary, annualTakeHomeSalary, taxAndInsurance;

        if (salary <= 0)
        {
            annualGrossSalary = 0;
            annualTakeHomeSalary = 0;
        }
        else if (salary <= 10000)
        {
            da = salary * 0.8;
            hra = salary * 0.2;
            netPay = salary + da + hra;
            annualGrossSalary = netPay * 12;
            taxAndInsurance = annualGrossSalary * 0.07;

            annualTakeHomeSalary = annualGrossSalary - taxAndInsurance;

        }
        else if (salary <= 20000)
        {
            da = salary * 0.9;
            hra = salary * 0.25;
            netPay = salary + da + hra;
            annualGrossSalary = netPay * 12;
            taxAndInsurance = annualGrossSalary * 0.07;

            annualTakeHomeSalary = annualGrossSalary - taxAndInsurance;
        }
        else
        {
            da = salary * 0.95;
            hra = salary * 0.3;
            netPay = salary + da + hra;
            annualGrossSalary = netPay * 12;
            taxAndInsurance = annualGrossSalary * 0.07;

            annualTakeHomeSalary = annualGrossSalary - taxAndInsurance;
        }


        Console.WriteLine("Annual Gross Salary: " + annualGrossSalary);
        Console.WriteLine("Annual Take-Home Salary: " + annualTakeHomeSalary);


    }
}
