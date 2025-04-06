using System;

class CALENDAR
{
    static void Main(string[] Args)
    {
        calendar(2);
    }

    static void calendar(int n)
    {
        string[] month = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        Console.WriteLine(month[(n-1)]);
    }
}