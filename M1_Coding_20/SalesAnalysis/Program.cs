using System;

class SalesAnalysis
{
    static void Main()
    {
        int[] sales = new int[7];
        int max = int.MinValue, min = int.MaxValue;
        int maxIndex = 0, sum = 0;

        for (int i = 0; i < 7; i++)
        {
            sales[i] = int.Parse(Console.ReadLine());
            sum += sales[i];

            if (sales[i] > max)
            {
                max = sales[i];
                maxIndex = i;
            }

            if (sales[i] < min)
                min = sales[i];
        }

        double avg = sum / 7.0;

        Console.WriteLine("Highest Sale: " + max);
        Console.WriteLine("Lowest Sale: " + min);
        Console.WriteLine("Average Sale: " + avg);
        Console.WriteLine("Day of Highest Sale (Index): " + maxIndex);
    }
}