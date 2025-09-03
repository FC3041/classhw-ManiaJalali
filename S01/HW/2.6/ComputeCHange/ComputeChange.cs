using System;

namespace firstsample
{
public class CompChange
{
    public static void ComputeChange(int cents)
    {
        int change = 100 - cents;
        int quarters = change / 25;
        change %= 25;
        int dimes = change / 10;
        change %= 10;
        int nickels = change / 5;
        change %= 5;
        int pennies = change;

        Console.Write(quarters + " : quarters\n" + dimes + " : dimes\n" + nickels + " : nickels\n" + pennies + " : pennies");
    }
    public static void Main()
    {
        ComputeChange(8);
    }
}
}