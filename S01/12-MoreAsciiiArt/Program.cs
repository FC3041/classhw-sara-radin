using System;

class MOREASCIIIART
{
    static void Main(string[] Args)
    {
        print_left_triangle(4);
        print_left_triangle(20);
    }

    static bool ifodd(int n)
    {
        if (n%2 == 1)
            return true;
        else
            return false;
    }

    static int print_left_triangle(int n)
    {
        for(int i = 0 ; i<=n;i++)
        {
            if (ifodd(i) == true)
                Console.WriteLine(new string('&', i) + new string(' ', n - i));
            else
                Console.WriteLine(new string('*', i) + new string(' ', n - i));
        }
        return 0 ;
    }

    
}