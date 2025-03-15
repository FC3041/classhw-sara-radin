namespace S8con;

public class Program
{
    public static int add(int a,int b)
    {
        return a+b ;
    }



    //     static void Main(string[] args)
    // {
    //     for(int i =0;i<args.Length;i++)
    //     {
    //         System.Console.WriteLine($"ars{i}:{args[i]}");
    //     }
    //     Console.WriteLine("Hello,World!");
    // }

    public static void reverse(string s, out string srev)
    {
        srev = "";
        foreach(char c in s)
            srev= c+ srev;
    }

    public static void reverse_word(string s, out string srev)
    {
        srev = "";
        string n="";
        foreach(char c in s)
        {
            if (c == ' ')
            {
                srev = n + " " + srev;
                n = ""; 
            }
            else
            {
                n+=c;
            }
        }            
    }

    static void PREPEND_USER(string S,out string sout)
    {
        sout = "user:"+S;
    }

    static void Main(string[] args)
    {
        string name = "right now i am doing my homework at library and now it's sunday 11.56pm 9.March";
        string name2= "Now it is 12:06PM Monday 10th March and hopefully I have an exam tomorrow and didnt study for it yet; actually, not tomorrow, today.)";
        string srev;    
        reverse_word(name,out srev);
        System.Console.WriteLine(srev);
        reverse_word(name2,out srev);
        System.Console.WriteLine(srev);
    }

    static void Main2(string[] args)
    {
        string name = "fateme";
        string srev;
        reverse(name,out srev);
        System.Console.WriteLine((srev));
    }

    static void Main1(string[] args)
    {
        int sum = 0 ;
        while(true)
        {
            System.Console.WriteLine("Nums?");
            string s = Console.ReadLine();
            if(string.IsNullOrEmpty(s))
                break;

            int n;
            if(!int.TryParse(s,out n))
            {
                System.Console.WriteLine("wrong! Try again");
                continue;
            }
            string sout;
            PREPEND_USER(s,out sout);
            System.Console.WriteLine(sout);
            sum+= n;
        }

        System.Console.WriteLine(sum);
    }

    // static void Main(string[] args)
    // {
    //     for(int i =0;i<args.Length;i++)
    //     {
    //         System.Console.WriteLine($"ars{i}:{args[i]}");
    //     }
    //     Console.WriteLine("Hello,World!");
    // }
}

