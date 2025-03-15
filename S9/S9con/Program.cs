using System.ComponentModel;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace S9con;

class Program
{
    static void Main1(string[] args)
    {
        int x = int.Parse("534");
        int y = 5;
        if (y.CompareTo(x) > 0)
            System.Console.WriteLine("-");
        Console.WriteLine(y.ToString());

        int i = 5;
        object o = i;
        int n = (int) o;

        Student s = new Student(
            name:"Zhale Hosseini", 
            stdid: 403521, 
            natid: 837743647, 
            credits: 17,
            active: true);

        string str = "Zhale Hosseini,403521,837743647,17,True";
        Student sc = Student.Parse(str);
        System.Console.WriteLine(sc.Equals(1234));

        File.WriteAllLines("test.csv", new string[]{s.ToString(), sc.ToString()});
        string[] lines = File.ReadAllLines("test.csv");
        foreach(var line in lines)
        {
            var ss = Student.Parse(line);
            System.Console.WriteLine(ss.credits);
        }

    }


    static void Main(string[] args)
    {
        while (true){
        System.Console.WriteLine("Please enter your name");
        string Name = Console.ReadLine();
        if (Name == "finish")
        {
            break;
        }
        System.Console.WriteLine("Please enter your student ID");
        int Stdid = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter your national ID");
        int Natid = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter the credits you have passed");
        int Credits = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter 'true' if you are active, and 'false' if you are not");
        bool Active = bool.Parse(Console.ReadLine());
        Student s = new Student(
            name:Name, 
            stdid: Stdid, 
            natid: Natid, 
            credits: Credits,
            active: Active);
        try
        {
            File.AppendAllLines("test.csv", new string[] {s.ToString()});
        }
        catch (Exception)
        {
            Console.WriteLine("You entered something incorrect. Please try again.");
        }




        
    }}
}
