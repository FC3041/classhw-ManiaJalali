using System;

namespace firstsample
{
public class Program
{
    public static int absolute_value(int x)
    {
        if (x > 0)
            return x;
        return -x;
    }
    static void Main()
    {
        int a = absolute_value(-6);
        Console.WriteLine(a);
    }
}
}