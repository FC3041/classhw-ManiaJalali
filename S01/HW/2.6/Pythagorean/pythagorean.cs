using System;

public class Pyth
{
    public static void Pythagorean_Triples()
    {
        for(int a=1;a<101;a++)
        {
            for(int b=1;b<101;b++)
            {
                for (int c = b + 1; c <= 100; c++) 
                { 
                    if ((a * a + b * b) == c * c)
                    { 
                        Console.Write("a\n" + a +"b\n" + b + "c\n" + c);
    }}}}}       
    static void Main()
    {
        Pythagorean_Triples();
    }
}