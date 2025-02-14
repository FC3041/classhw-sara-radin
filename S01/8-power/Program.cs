using System;


class POWER
{
    static void Main(string[] Args)
    {
        power(2,3);
    }

    static void power(int x , int y)
    {
        int result = 1;
        if (y>=0)
        {
            for(int i = 0;i<y;i++)
            {
                result = result * x;
            }
            Console.WriteLine(result);
        }
    }
}