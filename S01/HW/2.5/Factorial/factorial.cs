using System;

namespace h
{
public class Factor
{
    public static int factorial(int n)
    {
        int result;
        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }

    static void Main()
    {
        for(int i = 1; i <= 20; i++)
        {
            int F = factorial(20);
            Console.Write(F + "\n");
        }
    }
}
}