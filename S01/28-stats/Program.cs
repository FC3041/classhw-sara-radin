using System;
using System.Collections.Generic;

class STATS
{
    static void Main(string[] Args)
    {
        stats();
    }

    static void stats()
    {
        double n = 0;
        double sum = 0;
        double min = double.MaxValue;
        double max =double.MinValue;
        int x = 0;
        double average = 0;
        while(n!=-1)
        {
            Console.Write("number?");
            n = double.Parse(Console.ReadLine());
            sum += n;
            if (n<min && n!=-1)
                min = n;
            if (n>max && n!=-1)
                max = n;
            x ++;
        }
        if (x>0)
            average = (sum+1)/(x-1);
        else
            average=0;
        Console.WriteLine($"Number of entries: {x-1}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Maximum: {max}");
    }


}