using System;


class FTOC
{
    static void Main(string[] args)
    {
        froc(41.999999);
    }
    static void froc(double f)
    {
        double c = 5*(f-32)/9;
        Console.WriteLine($"{c:F2}");
    }
}
