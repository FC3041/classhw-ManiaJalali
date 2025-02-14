using System;

public class power
{
    public static int power(int x, int y)
    {
        int j = 1;
        if(y > -1)
        {
            for(int i = 0; i < y; i++)
                j *= x;
        }
        return j;
    }

    static void main() 
    { 
        int result = power(2, 3); 
        Console.Write(result);
    }
}
