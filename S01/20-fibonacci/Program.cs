using System;

class FIBONACCI
{
    static void Main(string[] Args)
    {
        Console.WriteLine(Fibonacci(5));
        fibonacci(20);
    }

    static int Fibonacci(int n)
    {
        if (n <= 0) 
            return 0;
        if (n == 1 || n == 2) 
            return 1;
        int x1=1;
        int x2=1;
        int xt=1;
        for(int i = 3 ;i<=n;i++)
        {
            xt = x1 + x2;
            x1=x2;
            x2=xt;
        }
        return xt;
    }

    static void fibonacci(int n)
    {
        for ( int i = 1; i<=n;i++)
            Console.WriteLine(Fibonacci(i));
    }


}