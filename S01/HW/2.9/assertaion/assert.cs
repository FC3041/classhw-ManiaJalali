using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Factorial(5));
        Console.WriteLine(IsPrime(5));  
    }

    public static int Factorial(int n)
    {
        if (n < 0)
        {
            return -1;
        }

        int result = 1;
        
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        
        return result;
    }
    public static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
