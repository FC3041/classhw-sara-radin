using System;



class ABS
{
    static void Main(string[] Args)
    {
        Console.WriteLine(function_near(100,93,0.001));
        Console.WriteLine(function_near(100,99.9999,0.001));
        Console.WriteLine(function_near(exp(2, .000001),exp2(2, .000001),0.001));

    }


    static bool function_near(double x , double y, double precision)
    {
        double colseness = (max(x,y))*precision;
        if (abs_dist(x,y)<=colseness)
            return true;
        else 
            return false;
    }
    static double max(double x , double y)
    {
        if (x>y)
            return x ;
        else
            return y;
    }

    static double abs(double x)
    {
        if (x<0)
            return (x*(-1));
        else
            return x;
    }

    static double abs_dist(double x , double y)
    {
        return abs((x-y));
    }



    static double computefraction(double n)
    {
        double r = 1;
        if (n == 0 || n == 1)
            r = 1;
        else
        {
            for (double i = 1; i <= n; i++)
            {
                r *= i;
            }
        }
        return 1.0 / r;
    }

    static double power(double x,double n)
    {
        double result = 1;
        if (n==0)
            result =1;
        else
            for (double i = 0;i<n;i++)
                result = result * x;
        return result;
    }

    static double exp(double x, double precision)
    {
        double sum = 0;
        double n = 0;
        double T = computefraction(n) * power(x, n);
        while (T > precision)
        {
            sum += T;
            n++;
            T = computefraction(n) * power(x, n);
        }
        return sum;
    }

    static double exp2(double x , double precision)
    {
        double sum = 1;
        double n = 1;
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