using System;

class SQUARE_ROOT
{
    static void Main(string[] Args)
    {
        Console.WriteLine(root(2,2,0.000001));
        Console.WriteLine(root(256,8,0.000001));
    }

    static double root(double x,double y,double precision)
    {
        if (x<0 && y % 2 == 0)
        {
            Console.WriteLine("Negative Number dosent have even root:)");
            return -1 ;
        }

        if (x==0)
            return 0;
        double lowerBound=0;
        double upperBound=0;
        double mid = 0;
        if (x>1)
            upperBound=x;
        else
            upperBound=1;
        while((upperBound-lowerBound)>precision)
        {
            mid = (lowerBound + upperBound)/2;
            if (power(mid,y)<x)
                lowerBound = mid;
            else
                upperBound = mid;
        }
        return (lowerBound + upperBound) / 2.0;
        
    }

    static double power(double x , double y)
    {
        double result = 1;
        for (int i = 0;i<y;i++)
            result*=x;
        return result;
    }


}