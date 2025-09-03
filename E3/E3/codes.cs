




public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class MyPointType1
{
    private int X_;
    public int X
    {
        get => X_;
        set
        {
            X_ = value;
        }
    }
    private int Y_;
    public int Y
    {
        get => Y_;
        set
        {
            Y_ = value;
        }
    }

    // public MyPointType1(int x, int y)
    // {
    //     this.X = x;
    //     this.Y = y;
    // }

}

public struct MyPointType2
{
    private int X_;
    public int X
    {
        get => X_;
        set
        {
            X_ = value;
        }
    }
    private int Y_;
    public int Y
    {
        get => Y_;
        set
        {
            Y_ = value;
        }
    }


}

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public string Compare(Product x, Product y)
    {
        if (x.Name.Length > y.Name.Length)
        {
            return x.Name;
        }
        return y.Name;

    }
}
//---------------------------2-----------------------------------------

// public class Comparer<T> : IComparable<T>
// {
//     public T v1;
//     public T v2;

//     public Comparer(T v1, T v2)
//     {
//         this.v1 = v1;
//         this.v2 = v2;
//     }


//     public int CompareTo(T? other)
//     {
//         if (v1 > v2)
//         {
//             return -1;
//         }
//     }
//     public T GetLarger()
//     {
//         throw new NotImplementedException();
//     }

//     // public static bool operator >(T t1, T t2)
//     // {
//     //     if 
//     // }
//     // public static bool operator <(T t1, T t2)
//     // {

//     //}
// }

// public static class ComparerExtensions
// {
//     public static string compare_s(this string s1, string s2)
//     {
//         if (s1.Length > s2.Length)
//         {
//             return s1;
//         }
//         return s2;
//     }
// }

//-------------------3----------------------------------------

public class ResourceManager:IDisposable
{
    public bool IsDisposed { get; private set; }
    public ResourceManager()
    {

    }

    

    public void Dispose()
    {
        IsDisposed = true;
    }
}

//--------------------4---5------------------------------------
public class LinqProblems
{

    public static IEnumerable<int> FilterAndDouble(List<int> numbers)
    {
        return numbers.Where(x => x % 2 == 0 && x > 5).Select(x => x * 2).ToList();
    }

    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(a => a.Category).ToDictionary(p => p.Key, p => p.Sum(a => a.Amount));


    }
}

public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }
}

public class Money
{
    public int Amount;
    public string v2;

    public Money(int v1, string v2)
    {
        this.Amount = v1;
        this.v2 = v2;
    }

    public static Money operator +(Money a, Money b)
    {
        int tr = a.Amount + b.Amount;

        return new Money(tr, a.v2);
    }

    public bool Equals(Money other)
    {
        if (this.v2 == other.v2 && this.Amount == other.Amount)
        {
            return true;
        }
        return false;
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }
}
//----------------------7--------------------------------
public class DelegateProblems
{
    public static string u;
    public static string ToUpper { get=>u; set
        {
            u = value;
    } }
    public static string ToLower { get => u; set
        {
            u= value;
    } }


    public static string ProcessString(string input, object obj)
    {
        u = input;
       
        if (obj == ToLower)
        {
            return input.ToLower();
        }
        else return input.ToUpper();
    }
    

}


public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()
    {
        throw new NotImplementedException();
    }
}

// public  class Closures
// {
//     private static  int t=0;
//     // public int count()
//     // {
//     //     int s = this.t++;
//     //     return s;

//     // }
    
//     public  int count
//     {
//         get { return t++; }
//         set{ t = value; }
//     }
//     public static Func<int> CreateCounter()
//     {
//         return count;
//     }
// }