using System;

class DAYSINMONTH
{
    static void Main(string[] Args)
    {
        Console.WriteLine(daysinmonth(2,2024));
        Console.WriteLine(daysinmonth(2,2023));
        Console.WriteLine(daysinmonth(1,2024));
        Console.WriteLine(DaysBeforeDate(2014, 1, 1));   
        Console.WriteLine(DaysBeforeDate(2014, 12, 31));
        Console.WriteLine(day_of_the_week(2014, 1, 1)); 
        Console.WriteLine(day_of_the_week(2014, 12, 31));
    }

    static int daysinmonth(int n,int year)
    {
        int[] t;
        if (LeapYear(year)==false)
            t = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        else
            t = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return t[n-1];
    }

    static bool LeapYear(int year)
    {
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            return true;
        else
            return false;
    }


    static int DaysBeforeDate(int year, int monthNumber, int dayNumber)
    {
        int daysCount = 0;
        for (int month = 1; month < monthNumber; month++)
        {
            daysCount += daysinmonth(month, year);
        }
        daysCount += (dayNumber - 1);
        return daysCount;
    }

    static string day_of_the_week(int year, int month, int day)
    {
        int j =( DaysBeforeDate(year,month,day)%7);
        string[] t = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        return t[(j + 2) % 7];
    }
    
}