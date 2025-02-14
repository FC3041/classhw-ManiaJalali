using System;

namespace firstsample
{
class Calendar
{
    public static void print_month(int monthNumber, string[] months)
    {
        if (monthNumber > 0 && monthNumber <= 12) 
        {
            Console.WriteLine(months[monthNumber - 1]);
        }
    }

    static void Main()
    {
        string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        for (int i = 1; i < 13; i++) 
        {
            print_month(i, months);
        }
    }
}
}