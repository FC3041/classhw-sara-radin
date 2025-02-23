using System;

class Rocketship
{
    static void Main(string[] args)
    {
        Head();
        Line();
        for(int i =0;i<6;i++)
        {
            Body();
            Line();
        }
        Head();
    }
    static void Head()
    {
       Console.WriteLine("     ^     ");
       Console.WriteLine("    /|\\    ");
       Console.WriteLine("   //|\\\\   ");
       Console.WriteLine("  ///|\\\\\\  "); 
    }
    static void Body()
    {
        Console.WriteLine(" +*******+ ");
        Console.WriteLine(" +*******+ ");
        Console.WriteLine(" +*******+ ");       
        Console.WriteLine(" +*******+ ");
    }
    static void Line()
    {
        Console.WriteLine(" +-------+ ");
    }

}

