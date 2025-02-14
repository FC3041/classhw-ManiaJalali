using System;

namespace firstsample
{
    public class Leapyear
    {
        public static void is_leap_year(int year)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    Console.WriteLine("Is Leap Year");
                else
                    Console.WriteLine("Is not Leap Year");
            }
            else
            {
                if (year % 4 == 0)
                    Console.WriteLine("Is Leap Year");
                else
                    Console.WriteLine("Is not Leap Year");
            }
        }

        static void Main()
        {
            is_leap_year(1792);
            is_leap_year(1796);
            is_leap_year(1800);
            is_leap_year(1804);
            is_leap_year(1900);
            is_leap_year(1904);
            is_leap_year(2000);
            is_leap_year(2004);
        }

    }
}