using System;

class  ABSOLUTE
{
    static void Main(string[] Args)
    {
        absolute(-100);
        absolute(-1);
        absolute(0);
        absolute(1);
        absolute(100);
    }


    static void absolute(int n)
    {
        if (n<0)
            Console.WriteLine(-1*n);
        else
        {
            Console.WriteLine(n);
        }
    }
}