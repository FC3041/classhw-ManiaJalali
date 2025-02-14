using System;

class Rocket
{
    public static void Cone(int l)
    {
        for (int i=0;i<=((l / 2) + 1);i++)
        {
            Console.Write(" ");
        }
        Console.Write("^\n");
        for(int i =0; i<l; i+=2)
        {
            int x = (l-i)/2;
            int newi = (i / 2) + 1;
            for (int j=0;j<=x;j++)
            {
                Console.Write(" ");
            }
            for (int j=0;j<newi;j++)
            {
                Console.Write("/");
            }
            Console.Write("|");
            for (int j=0;j<newi;j++)
            {
                Console.Write("\\");
            }
            Console.Write("\n");
        }
    }

    public static void Line(int l)
    {
        Console.Write("+");
        for (int i=0; i<l; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
    }

    public static void Trunk(int l, int h)
    {
        for (int i = 0; i < h;i++)
        {
            Console.Write("+");
            for (int j = 0; j < l; j++)
            {
                Console.Write("*");
            }
            Console.Write("+\n");
        }
    }

    static void Main()
    {
        Cone(5);
        Line(7);
        Trunk(7,4);
        Line(7);
        Trunk(7,4);
        Line(7);
        Cone(5);
    }
}