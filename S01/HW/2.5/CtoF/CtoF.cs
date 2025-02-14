using System;

class CelsiustoFahrenheit
{
    public static void ctof(int C)
    {
        double F =(9.0 / 5.0) * C + 32;
        Console.WriteLine(F);
    }
    static void Main()
    {
        ctof(54);
    }
}