using System;

class Stats
{
    static void Main()
    {
        float sum = 0, min = float.MaxValue, max = float.MinValue, number;
        int count = 0;
        
        Console.WriteLine("Enter numberss.Write -1 to stop.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-1")
                break;

            if (float.TryParse(input, out number))
            {
                sum += number;
                if (number < min) min = number;
                if (number > max) max = number;
                count++;
            }
        }
        float average = sum / count;
        Console.WriteLine("Number of entries: " + count);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Minimum: " + min);
        Console.WriteLine("Maximum: " + max);
        
    }
}
