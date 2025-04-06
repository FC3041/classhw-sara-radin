using System;

class AVERAGEOFSQUARES
{
    static void Main(string[] Args)
    {
        avergeofsquares0(5);
        avergeofsquares1(4);
    }
    static double power(double x , double y)
    {
        double result = 1;
        if (y>=0)
        {
            for(int i = 0;i<y;i++)
            {
                result = result * x;
            }
            
        }
        return result;
    }

    static  void averge(double result, double n)
    {
        double T = result / n;
        Console.WriteLine($"{T:F2}");
    }

    static void avergeofsquares0(double n)
    {
        double result = 0;
        for(double i = 0;i<n;i++)
        {
            double g = power(i,2);
            result += g;
        }
        averge(result,n);
    }

        static void avergeofsquares1(double n)
    {
        double result = 0;
        for(double i = 1;i<=n;i++)
        {
            double g = power(i,2);
            result += g;
        }
        averge(result,n);
    }
}