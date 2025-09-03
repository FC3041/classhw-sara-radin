using System;

class PYTHAGOREAN
{
    static void Main(string[] Args)
    {
        pythagorean(100);
    }

    static void pythagorean(int t)
    {
        for (int a = 0;a<=t;a++)
        {
            for (int b=0;b<=t;b++)
            {
                for (int c =0;c<=t;c++)
                {
                    if (a*a + b*b == c*c)
                    {
                        Console.WriteLine($"a={a},b={b},c={c}");
                    }
                }
            }
        }
    }
}