// using System;

// class date
// {
//     int[] list1 = {31,28,31,30,31,30,31,31,30,31,30,31};
//     int[] list2 = {31,29,31,30,31,30,31,31,30,31,30,31};
//     string[] list3 = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

//     static int days_in_month(int year,int monthNumber)
//     {
//         if (year %100 == 0)
//             {if (year%400 == 0)
//                 return list2[monthNumber-1];
//             else
//                 return list1[monthNumber-1];}
//         else
//             {if (year%4 == 0)
//                 return list2[monthNumber-1];
//             else
//                 return list1[monthNumber-1];}
//     }
//     static int days_before_date(int year,int monthNumber,int dayNumber)
//     {
//         int days = 0;
//         if (year %100 == 0)
//         {    
//             if (year%400 == 0)
//                 {
//                     for (int i = 0; i< monthNumber - 1; i++)
//                         days += list2[i];
//                     days += dayNumber;
//                 }
//             else
//                 {
//                     for (int i = 0; i< monthNumber -1; i++)
//                     days += list1[i];
//                     days += dayNumber;
//                 }
//         }
//         else
//             {
//                 if (year%4 == 0)
//                 {
//                     for (int i = 0; i< monthNumber - 1; i++)
//                         days += list2[i];
//                     days +=dayNumber;
//                 }
//                 else
//                 {
//                     for (int i = 0; i< monthNumber - 1; i++)
//                         days += list1[i];
//                     days += dayNumber;
//                 }
//             }
//         return days;
//     }

//     static char day_of_the_week(int year, int monthNumber, int dayNumber) 
//     { 
//         int days = days_before_date(year, monthNumber, dayNumber); 
//         int mabna = days % 7; 
//         return list3[mabna]; 
//     }

//     static void Main()
//     {
//         Console.WriteLine(day_of_the_week(2024,11,22));
//         Console.WriteLine(days_before_date(2012,12,31));
//     }
// }