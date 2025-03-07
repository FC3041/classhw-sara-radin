using System;

class SIN
{
    static void Main(string[] Args)
    {
        Console.WriteLine($"sin(45 degrees) = {Sin(45, 0.000001)}");  
        Console.WriteLine($"sin(90 degrees) = {Sin(90, 0.000001)}");  
        Console.WriteLine($"sin(0 degrees) = {Sin(0, 0.000001)}");
    }

    static double Sin(double x, double precision)
    {
        x = x * (Math.PI / 180); 
        double sum = 0;
        double term = x;
        int n = 1;

        while (Math.Abs(term) > precision)
        {
            sum += term;
            n++;
            term = -term * x * x / ((2 * n - 2) * (2 * n - 1));
        }

        return sum;
    }
}
