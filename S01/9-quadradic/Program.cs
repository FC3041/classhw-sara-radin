using System;

class Q
{
    static void Main(string[] Args)
    {
        q(1,5,6);
    }

    
    static double power(double x, double y)
    {
        return Math.Pow(x, y); 
    }
  

    static void q(double A , double B , double C)
    {
        double teta = (power(B,2)) - 4*A*C;
        if (teta >= 0)
        {
            double x1 = ((-B) + (power(teta,0.5)))/(2*A);
            double x2 = ((-B) - (power(teta,0.5)))/(2*A);
            Console.WriteLine($"{x1:F2}, {x2:F2}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}