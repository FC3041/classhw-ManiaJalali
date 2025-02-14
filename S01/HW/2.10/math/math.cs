using System;

class Mathh
{
    public static double Factorial(int n)
    {
        if (n == 0) return 1;
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static double EulersConstant(double precision)
    {
        double e = 1.0;
        int n = 1;
        while (1.0 / Factorial(n) > precision)
        {
            e += 1.0 / Factorial(n);
            n++;
        }
        return e;
    }

    public static double Exp(double x, double precision)
    {
        double sum = 1.0;
        double term = 1.0;
        int n = 1;
        while (term > precision)
        {
            term = term * x / n;
            sum += term;
            n++;
        }
        return sum;
    }

    public static double Sin(double degrees, double precision)
    {
        double radians = degrees * Math.PI / 180;
        double sum = radians;
        double term = radians;
        int n = 1;
        while (Math.Abs(term) > precision)
        {
            term = -term * radians * radians / ((2 * n) * (2 * n + 1));
            sum += term;
            n++;
        }
        return sum;
    }

    public static double SquareRoot(double x, double precision)
    {
        if (x < 0)
            Console.WriteLine("x must not be negative");
        double lowerBound = 0;
        double upperBound = x;
        double mid = 0;
        while ((upperBound - lowerBound) > precision)
        {
            mid = (lowerBound + upperBound) / 2;
            if (mid * mid > x)
            {
                upperBound = mid;
            }
            else
            {
                lowerBound = mid;
            }
        }
        return mid;
    }

    static void Main()
    {
        Console.WriteLine($"Euler's constant (precision 0.0001): {EulersConstant(0.0001)}");
        Console.WriteLine($"exp(1, 0.000001): {Exp(1, 0.000001)}");
        Console.WriteLine($"exp(2, 0.000001): {Exp(2, 0.000001)}");
        Console.WriteLine($"sin(45 degrees, 0.0001): {Sin(45, 0.0001)}");
        Console.WriteLine($"sin(90 degrees, 0.0001): {Sin(90, 0.0001)}");
        Console.WriteLine($"Square root of 2 (precision 0.000001): {SquareRoot(2, 0.000001)}");
    }
}
