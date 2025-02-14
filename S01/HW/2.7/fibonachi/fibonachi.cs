using System;

class Fibo
{
    public static int fibonatchi(int n)
    {
    if ((n == 1) || (n ==2))
        {
            return 1;
        }
        return (fibonatchi(n-1) + fibonatchi(n-2));
    }

    static void Main() 
    { 
        for (int i = 1; i <= 20; i++) 
        {
            int a = fibonatchi(i);
            Console.WriteLine("output " + i + " : " + a); 
        }
    }
}