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
        if (n <= 0)
        {
            throw new ArgumentException("n must be positive");
        }
        double result = 1;
        for(double i = 1 ;i<n+1;i++)
        {
            result= result*i;
        }
        Console.WriteLine(result);
    }

    static bool prime(int n)
    {
        if (n<=1)
            return false;
        if (n==2)
            return true;
        else
        {
            for (int i =2 ; i<n;i++)
            {
                if (n%i==0)
                    return false;
            }
        }
        return true;
    }

    static void is_prime(int s)
    {
        if (n <= 0)
        {
            throw new ArgumentException("n must be positive");
        }
        for (int i=0;i<=s;i++)
        {
            if (prime(i)==true)
                Console.WriteLine(i);
        
        }
    }    
    
}