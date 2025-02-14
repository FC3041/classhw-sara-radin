using System;

class MOREASCIIIART
{
    static void Main(string[] Args)
    {
        print_cone(7);
        all_cones(9);
    }

    static bool ifodd(int n)
    {
        if (n%2 == 1)
            return true;
        else
            return false;
    }

    static void print_cone(int baseSize)
    {
        if (ifodd(baseSize)==true)
        {
            int t = ((baseSize-1)/2);
            for(int i =0 ; i<=t;i++)
            {
                if (i==0)
                    Console.WriteLine(new string(' ', t-i) + new string('^', 1));
                else
                    Console.WriteLine(new string(' ', t-i) +new string('/', i)+ new string('|', 1)+new string('\\', i));

            }
        }
        else
        {
            Console.WriteLine("The base size must be an odd number.");
        }
    }

    static void  all_cones(int n)
    {
        if (n%2==0)
        {
            for(int i = 0;i<=n;i++)
            {
                print_cone(i);
            }
        }
    }
}