using System;

class FACTORIAL
{
    static void Main(string[] args)
    {
        factorial(19);
        factorial2(19);
    }
    static void factorial(double n)
    {
        double result = 1;
        for(double i = 1 ;i<n+1;i++)
        {
            result= result*i;
        }
        Console.WriteLine(result);
    }

    static void factorial2(double n)
    {
        double result = 1;
        for(double i = 1 ;i<n+1;i++)
        {
            result= result*i;
            Console.WriteLine($"{i}! = {result}");
        }
        
    }
}