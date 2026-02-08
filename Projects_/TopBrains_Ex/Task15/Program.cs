using System;

public class Program
{
    public static void Main(string[] args)
    {
        double?[] values = { 10.5, null, 20.25, null, 30.1 };

        double? result = ComputeAverage(values);

        if (result == null)
            Console.WriteLine("null");
        else
            Console.WriteLine(result);
    }

    static double? ComputeAverage(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (var v in values)
        {
            if (v != null)
            {
                sum += v.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        double avg = sum / count;
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }
}
