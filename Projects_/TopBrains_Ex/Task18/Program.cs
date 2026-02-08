using System;

public class Program
{
    public static void Main(string[] args)
    {
        int feet = 10;
        Console.WriteLine(FeetToCentimeters(feet));
    }

    static double FeetToCentimeters(int feet)
    {
        double cm = feet * 30.48;
        return Math.Round(cm, 2, MidpointRounding.AwayFromZero);
    }
}
