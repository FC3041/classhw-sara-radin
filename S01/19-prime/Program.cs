using System;

class PRIME
{
    static void Main(string[] Args)
    {
        Console.WriteLine(is_divisible(10, 3)); 
        Console.WriteLine(is_divisible(9, 3));
        Console.WriteLine(prime(11));
        is_prime(100);
    }

    static bool is_divisible(int a , int b)
    {
        if (a%b==0)
            return true;
        else
            return false;
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
        for (int i=0;i<=s;i++)
        {
            if (prime(i)==true)
                Console.WriteLine(i);
        
        }
    }
}