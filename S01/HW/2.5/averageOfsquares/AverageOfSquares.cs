using System;

class AverageOfSquares
{
    public static float average_of_squares0(int n)
    {
        float sum = 0;
        for(int i = 0; i < n; i++)
        {
            sum = sum + (i*i);
        }
        return sum/n;
    }

    public static float average_of_squares1(int n)
    {
        float sum = 0;
        for(int i = 1; i< n+1; i++)
        {
            sum = sum + (i*i);
        }
        return sum/n;
    }

    static void Main()
    {
        float s;
        s = average_of_squares0(6);
        Console.WriteLine(s);
        s = average_of_squares1(6);
        Console.WriteLine(s);
    }
}