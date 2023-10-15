using System;
class Program
{
    public static void Main(string[] args)
    {
        bool value = false, value1;
        value1 = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime userInputDate);


        int noOfHolidays = Convert.ToInt32(Console.ReadLine());

        DateTime[] holidayDates = new DateTime[noOfHolidays];

        for (int i = 0; i < noOfHolidays; i++)
        {

            value = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out holidayDates[i]);

        }

        bool flag = false;
        if (value & value1)
        {
            string day = userInputDate.DayOfWeek.ToString();
            if (day.Equals("Sunday") || day.Equals("Saturday"))
            {
                Console.WriteLine("Holiday:-)");
            }
            else
            {
                for (int i = 0; i < noOfHolidays; i++)
                {
                    if (userInputDate == holidayDates[i])
                    {
                        Console.WriteLine("Holiday:-)");
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("Not an Holiday:-(");
                }

            }
        }

    }
}