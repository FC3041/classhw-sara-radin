using System;


class CTOF
{
    static void Main(string[] args)
    {
        ctof(5.84454);
    }
    static void ctof(double c)
    {
        double f = (9*c/5)+32;
        Console.WriteLine($"{f:F2}");
    }
}
