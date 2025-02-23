using System;

class COMPUTECHANGE
{
    static void Main(string[] Args)
    {
        compute_change(33);
    }

    static void compute_change(int t)
    {
        int n = 100 - t;
        int q = n/25;
        int d = (n-q*25)/10;
        int n2 =(n - q*25 - d*10)/5;;
        int p = (n -( q*25 + d*10 + n2*5))/1;
        Console.WriteLine($"The change from a dollar for {t} cents is:");
        Console.WriteLine($"Quarters: {q}");
        Console.WriteLine($"dime:{d}");
        Console.WriteLine($"nickel:{n2}");
        Console.WriteLine($"pennies:{p}");
    }
}