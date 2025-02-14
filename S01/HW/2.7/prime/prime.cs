using System;

namespace firstsample
{
class Program
{
    static bool IsDivisible(int a, int b)
    {
        return a % b == 0;
    }

    static bool IsPrime(int N)
    {
        if (N <= 1) return false;
        for (int x = 2; x < N; x++)
        {
            if (IsDivisible(N, x)) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Prime numbers less than 100:");
        for (int i = 2; i < 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}
}