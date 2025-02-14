using System;

class Rocket
{
    static void Main()
    {
        int l1 = 5,l = 7 , h = 5;
        for (int i=0;i<=((l1 / 2) + 1);i++)
        {
            Console.Write(" ");
        }
        Console.Write("^\n");
        for(int i =0; i<l1; i+=2)
        {
            int x = (l1-i)/2;
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

        Console.Write("+");
        for (int i=0; i<l; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");

        for (int i = 0; i < h;i++)
        {
            Console.Write("+");
            for (int j = 0; j < l; j++)
            {
                Console.Write("*");
            }
            Console.Write("+\n");
        }

        Console.Write("+");
        for (int i=0; i<l; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
        
        for (int i = 0; i < h;i++)
        {
            Console.Write("+");
            for (int j = 0; j < l; j++)
            {
                Console.Write("*");
            }
            Console.Write("+\n");
        }

        Console.Write("+");
        for (int i=0; i<l; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");

        for (int i=0;i<=((l1 / 2) + 1);i++)
        {
            Console.Write(" ");
        }
        Console.Write("^\n");
        for(int i =0; i<l1; i+=2)
        {
            int x = (l1-i)/2;
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
}