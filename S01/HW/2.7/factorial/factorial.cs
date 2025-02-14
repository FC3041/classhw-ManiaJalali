using System;

class factorial
{
    public static double Factorial(int n)
    {
        if (n < 0) 
        {
            Console.WriteLine("n must be non-negative");
            return -1;
        }

        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
            if (result <= 0) 
            {
                Console.WriteLine("result should be positive");
                return -1;
            }
        }

        if (result < 1) 
        {
            Console.WriteLine("result should be greater than or equal to 1");
            return -1;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("N    Factorial(N)");
        for (int i = 0; i <= 10; i++)
        {
            double factorial = Factorial(i);
            if (factorial != -1)
            {
                Console.WriteLine($"{i}\t{factorial}");
            }
        }
    }
}
