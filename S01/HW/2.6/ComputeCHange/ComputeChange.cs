using System;

public class CompChange
{
    public static void ComputeChange(int cents)
    {
        int quarters = cents / 25;
        cents %= 25;
        int dimes = cents / 10;
        cents %= 10;
        int nickels = cents / 5;
        cents %= 5;
        int pennies = cents;

        Console.Write(quarters + "quarters" + dimes + "dimes" + nickels + "nickels" + pennies + "pennies");
    }
    public static void Main()
    {
        ComputeChange(8);
    }
}