using System;

class EULERS_CONSTANT
{
    static void Main(string[] Args)
    {
        Console.WriteLine(eulers_constant(0.0001));
        Console.WriteLine(eulers_constant(0.00001));
        Console.WriteLine(exp(2, .000001));
        Console.WriteLine(exp(1, 0.000001));
        Console.WriteLine(exp(2, .000001));
        Console.WriteLine(exp(1, 0.000001));
    }

    static double computefraction(int n)
    {
        double r = 1;
        if (n == 0 || n == 1)
            r = 1;
        else
        {
            for (int i = 1; i <= n; i++)
            {
                r *= i;
            }
        }
        return 1.0 / r;
    }

    static double eulers_constant(double precision)
    {
        double sum = 0;
        int n = 0;
        while (computefraction(n) > precision)
        {
            sum +=  computefraction(n);
            n++;
        }
        return sum;
    }

    static double power(int x,int n)
    {
        double result = 1;
        if (n==0)
            result =1;
        else
            for (int i = 0;i<n;i++)
                result = result * x;
        return result;
    }

    static double exp(int x, double precision)
    {
        double sum = 0;
        int n = 0;
        double T = computefraction(n) * power(x, n);
        while (T > precision)
        {
            sum += T;
            n++;
            T = computefraction(n) * power(x, n);
        }
        return sum;
    }

    static double exp2(int x , double precision)
    {
        double sum = 1;
        int n = 1;
        double T = x/n;
        while(T>precision)
        {
            sum+=T;
            n++;
            T *= (x/n);
        }
        return sum;

    }
}
