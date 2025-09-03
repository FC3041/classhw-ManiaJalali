namespace csFinalExam;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

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
    public int X{ get; set; }
    public int Y{ get; set; }
}

public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class IAmAllowedToChangeItsNameComparer<T> where T : IComparable<T>
{
    private T _first;
    private T _second;

    public IAmAllowedToChangeItsNameComparer(T first, T second)
    {
        _first = first;
        _second = second;
    }

    public T GetLarger()
    {
        return _first.CompareTo(_second) >= 0 ? _first : _second;
    }
}

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        if (other == null) return 1;
        return Price.CompareTo(other.Price);
    }
}

public class ResourceManager : IDisposable
{
    public bool IsDisposed = false;
    public void Dispose()
    {
        IsDisposed = true;
    }
}

public class SafeCounter
{
    private int _count = 0;
    private readonly object _lock = new object();

    public void Increment()
    {
        lock (_lock)
        {
            _count++;
        }
    }

    public int Count => _count;
}

public class DataService
{
    public async Task<string> FetchDataAsync(string userId)
    {
        await Task.Delay(100); 
        return $"Data for {userId}";
    }
}

public static class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> num)
    {
        return num.Where(t => t > 5 & t % 2 == 0).Select(t => t * 2).ToList();
    }
    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(t => t.Category)
        .ToDictionary(g => g.Key, g => g.Sum(l => l.Amount));
    }
}

public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }

}

public class Money : IEquatable<Money>
{
    public int Amount { get; }
    public string Currency { get; }

    public Money(int amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount, a.Currency);
    }

    public static bool operator ==(Money a, Money b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.Amount == b.Amount && a.Currency == b.Currency;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Money);
    }

    public bool Equals(Money other)
    {
        return Amount == other.Amount && Currency == other.Currency;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}

public class DelegateProblems
{
    public static string ToUpper(string sA)
    {
        return sA.ToUpper().ToString();
    }
    public static string ToLower(string sA)
    {
        return sA.ToLower().ToString();
    }
    public delegate string to_call_func(string s);
    public static string ProcessString(string s, to_call_func f)
    {
        return f(s);
    }
}

public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator() => s => s.Length;
}