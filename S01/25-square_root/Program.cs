using System;



class SQUARE_ROOT
{
    static void Main(string[] Args)
    {
        Console.WriteLine(square_root(2, .000001));
        Console.WriteLine(square_root(256, .000001));
        Console.WriteLine(square_root(489, .000001));
    }

    static double square_root(double x , double precision)
    {
        if (x >= 0)
        {
            double lowerBound = 0;
            double upperBound=x;  
            double min = 0;      
            while((upperBound-lowerBound)>precision)
            {
                min = (lowerBound+upperBound)/2;
                if ((min*min)<x)
                    lowerBound = min;
                else
                    upperBound= min;
            }
            return min;
        }
        return 0;


    }


}
