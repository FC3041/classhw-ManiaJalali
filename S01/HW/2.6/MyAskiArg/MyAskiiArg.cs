using System;

namespace firstsample
{
    public class Aski
    {
        public static void print_cone(int baseSize)
        {
            for (int i = 0; i < baseSize/2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("^\n");
            
            for(int i = 1; i < baseSize; i += 2)
            {
                int x = (baseSize-i)/2;
                int newi = (i / 2) + 1;
                for (int j = 0 ; j < x-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0 ; j < newi; j++)
                {
                    Console.Write("/");
                }
                Console.Write("|");
                for (int j = 0 ; j < newi; j++)
                {
                    Console.Write("\\");
                }
                Console.Write("\n");
            }
        }
    static void Main()
    {
        for(int i = 1; i < 10 ; i += 2)
        {
            print_cone(i);
            Console.Write("\n");
        }
    }
    }
}