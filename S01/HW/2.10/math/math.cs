using System;

namespace sum
{
class Program
{
    static void Main()
    {
        float exam_it = SquareRoot(2, 0.000001f);
        Console.WriteLine(exam_it);
        Console.WriteLine(Sin(45, 0.000001f));  
        Console.WriteLine(Sin(90, 0.000001f));  
        Console.WriteLine(Sin(0, 0.000001f));
        Console.WriteLine(Root(8, 3, 0.000001f));
        Console.WriteLine(Ln(Math.E, 0.000001f));
        Console.WriteLine(Ln(1, 0.000001f));
    }

    static float EulersConstant(float precision)
    {
        int n = (int)(1 / precision);
        int g = 1;
        while (n > 10)
        {
            n /= 10;
            g++;
        }
        int factorial = 1;
        n = 1;
        float e = 1;
        while (1.0f / factorial >= precision)
        {
            factorial *= n;
            n++;
            e += 1.0f / factorial;
        }
        return e;
    }

    static int Power(int x, int y)
    {
        int p = 1;
        if (y >= 0)
        {
            for (int i = 0; i < y; i++)
                p *= x;
        }
        return p;
    }

    static int Factorial(int n)
    {
        int f = 1;
        if (n <= 1)
            f = 1;
        for (int i = 1; i <= n; i++)
            f *= i;
        return f;
    }

    static int Exp(int x, int precision)
    {
        int sum = 0;
        int n = 1 / precision;
        int g = 1;
        while (n > 10)
        {
            n /= 10;
            g++;
        }
        n = 0;
        while (Power(x, n) / Factorial(n) >= precision)
        {
            sum += Power(x, n) / Factorial(n);
            n++;
        }
        return sum;
    }

    static float Exp2(int x, float precision)
    {
        int n = (int)(1 / precision);
        int g = 1;
        while (n > 10)
        {
            n /= 10;
            g++;
        }
        float sum = 0;
        float term = 1;
        n = 1;
        while (term >= precision)
        {
            sum += term;
            term *= x / n;
            n++;
        }
        return sum;
    }

    static int Abs(int x)
    {
        if (x < 0)
            return -x;
        return x;
    }

    static bool Near(int x, int y)
    {
        float closeness = 0.001f;
        return (Abs(x - y) <= closeness * Math.Max(Abs(x), Abs(y)));
    }

    static double DegreesToRadians(int degrees)
    {
        double radians = (degrees * 3.14) / 180;
        return radians;
    }

    static double Sin(int x, float precision)
    {
        double j = DegreesToRadians(x);
        double term = j;
        double sum = j;
        int n = 1;
        int sign = -1;
        while (Math.Abs(term) > precision)
        {
            term *= j * j / ((2 * n) * (2 * n + 1));
            sum += sign * term;
            sign *= -1;
            n++;
        }
        return sum;
    }

    static float SquareRoot(int x, float precision)
    {
        if (x < 0)
            return 0;
        float low = 0;
        float high = Math.Max(1, x);
        float mid;
        while (high - low > precision)
        {
            mid = (low + high) / 2;
            if (mid * mid < x)
                low = mid;
            else
                high = mid;
        }
        return (low + high) / 2;
    }

    static float Root(int x, int n, float precision)
    {
        float low = 0;
        float high = Math.Max(1, x);
        float result;
        while (high - low > precision)
        {
            float mid = (low + high) / 2;
            if (Math.Pow(mid, n) < x)
                low = mid;
            else
                high = mid;
        }
        result = (low + high) / 2;
        return result;
    }

    static float Ln(double x, float precision)
    {
        float low = 0;
        float high = (float)x;
        float mid;
        if (x <= 0)
            return 0;
        while (high - low > precision)
        {
            mid = (low + high) / 2;
            if (Exp2((int)mid, precision) < x)
                low = mid;
            else
                high = mid;
        }
        return (low + high) / 2;
    }
}
}