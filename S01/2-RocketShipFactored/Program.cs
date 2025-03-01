using System;


class Program
{
    static void Main()
    {
        Head();
        Line();
        Body();
        Line();
        Head();
        PrintRocketShip();
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
    static void PrintRocketShip()
    {
        Console.WriteLine(@"     ^     ");
        Console.WriteLine(@"    /|\    ");
        Console.WriteLine(@"   //|\\   ");
        Console.WriteLine(@"  ///|\\\  ");
        Console.WriteLine(@" +-------+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +-------+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +*******+ ");
        Console.WriteLine(@" +-------+ ");
        Console.WriteLine(@"     ^     ");
        Console.WriteLine(@"    /|\    ");
        Console.WriteLine(@"   //|\\   ");
        Console.WriteLine(@"  ///|\\\  ");
    }
}

