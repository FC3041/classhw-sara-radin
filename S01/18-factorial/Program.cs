using System;


class FACTORIAL
{
    static void Main(string[] Args)
    {
        int m = factorial(5);
        Console.WriteLine(m);
    }

    static int factorial(int n)
    {
        int result = 1;
        for(int i = 1 ;i<n+1;i++)
        {
            result= result*i;
        }
        return result;
    }
}