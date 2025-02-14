using System;

public class sum
{
    public static int compute_sum(int n) 
    {
        int sum = 0;
        for (int i = 1; i < n + 2; i++) {
            sum += i;
        }
        return sum;
    }

    static void Main() 
    {
        Console.WriteLine("N      compute_sum(N)");
        Console.WriteLine("---------------------");
        for (int i = 9; i > 0; i--) 
        {
            Console.WriteLine(i + "     " +  compute_sum(i));
        }
    }
}