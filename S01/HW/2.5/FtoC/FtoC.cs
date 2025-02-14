using System;

class FahrenheittoCelsius
{
    public static void ftoc(int F)
    {
        double C = (F - 32) * (5.0 / 9.0) ;
        Console.WriteLine(C);
    }

    static void Main()
    {
        ftoc(50);
    }
}