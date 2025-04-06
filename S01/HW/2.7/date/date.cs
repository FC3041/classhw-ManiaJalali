using System;

namespace DayOfTheWeek
{
class Date
{
    static int[] list1 = {31,28,31,30,31,30,31,31,30,31,30,31};
    static int[] list2 = {31,29,31,30,31,30,31,31,30,31,30,31};
    static string[] list3 = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

    public static bool IsLeapYear(int year)
    {
        if (year % 100 == 0)
            return year % 400 == 0;
        else
            return year % 4 == 0;
    }

    public static int DaysInMonth(int year, int monthNumber)
    {
        if (IsLeapYear(year))
            return list2[monthNumber - 1];
        else
            return list1[monthNumber - 1];
    }

    public static int DaysBeforeDate(int year, int monthNumber, int dayNumber)
    {
        int days = 0;
    if (year %100 == 0)
    {    
        if (year%400 == 0)
            {
                for (int i = 0; i< monthNumber - 1; i++)
                    days += list2[i];
                days += dayNumber;
            }
        else
            {
                for (int i = 0; i< monthNumber -1; i++)
                days += list1[i];
                days += dayNumber;
            }
    }
    else
        {
            if (year%4 == 0)
            {
                for (int i = 0; i< monthNumber - 1; i++)
                    days += list2[i];
                days +=dayNumber;
            }
            else
            {
                for (int i = 0; i< monthNumber - 1; i++)
                    days += list1[i];
                days += dayNumber;
            }
        }
    return days;
    }

    public static string DayOfTheWeek(int year, int monthNumber, int dayNumber)
    {
        int days = DaysBeforeDate(year, monthNumber, dayNumber);
        int mabna = days % 7;
        return list3[mabna];
    }

    static void Main()
    {
        Console.WriteLine(DayOfTheWeek(2024, 11, 22));
        Console.WriteLine(DaysBeforeDate(2012, 12, 31));
    }
}
}