using System;


class ROCKET
{
    static void Main(string[] Args)
    {
        rocketship(11,7,4);
    }


    static void rocketship(int n,int y ,int s)
    {
        head(n);
        line(n);
        for(int i = 0;i<s;i++)
        {
            body(n,y);
            line(n);
        }
        head(n);
    }

    static void head(int n)
    {
        int C = (n-1)/2;
        Console.WriteLine(new string(' ', C)+new string('^', 1));
        for (int i = 1 ;i<=C ;i++)
             Console.WriteLine(new string(' ', C-i)+new string('/', i)+new string('|',1)+new string('\\', i));
    }

    static void line(int n)
    {
        Console.WriteLine(new string('+', 1)+new string('-', n-2)+new string('+', 1));
    }

    static void body(int n,int y)
    {
        for(int i=0;i<y;i++)
            Console.WriteLine(new string('+', 1)+new string('*', n-2)+new string('+', 1));
    }
}
