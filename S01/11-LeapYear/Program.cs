using System;

class LEAPYEAR
{
    static void Main(string[] Args)
    {
        LeapYear(1792);
        LeapYear(1796);
        LeapYear(1800);
        LeapYear(1804);
        LeapYear(1900);
        LeapYear(1904);
        LeapYear(2000);
        LeapYear(2004);
    }

    static void LeapYear(int year)
    {
        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}