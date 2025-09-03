using System;


class Triangle
{
    static void Main(string[] args)
    {
        lefttriangle(20);
        lefttriangle(20, '%'); 
        righttriangle(20);
    }
    static void lefttriangle(int b,char character = '*')
    {
        for (int i =0 ;i<=b;i++)
        {
            Console.WriteLine(new string(character, i) + new string(' ', b - i));
        }
    }
    static void righttriangle(int b)
    {
        for (int i =0 ;i<=b;i++)
        {
            Console.WriteLine(new string(' ', b - i) + new string('*', i));
        }
    }
}