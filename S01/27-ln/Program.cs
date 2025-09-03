using System;

class lowerBound
{
    static void Main(string[] Args)
    {
        Console.WriteLine(ln(2,0.00001));
    }
    static double ln(double x,double precision)
    {
        if(x<=0)
            return -1 ;
        double lowerBound =0;
        double upperBound =0;
        double mid =0;
        if (x>1)
            upperBound=x;
        else
            upperBound=1;
        while((upperBound - lowerBound)>precision)
        {
            mid = (lowerBound+upperBound)/2;
            if (exp(mid)<x)
                lowerBound = mid;
            else
                upperBound = mid ;
        }
        return (lowerBound+upperBound)/2;
    }

    static double exp(double x)
    {
        double sum = 1.0;
        double term = 1.0;
        for (int n = 1; Math.Abs(term) > 1e-10; n++)
        {
            term *= x / n;
            sum += term;
        }
        return sum;
    }

}