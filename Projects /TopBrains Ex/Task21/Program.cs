using System;

public class Program
{
    public static void Main(string[] args)
    {
        int totalSeconds = 125;
        Console.WriteLine(FormatTime(totalSeconds));
    }

    // Summary: Converts seconds into m:ss format with leading zero for seconds.
    static string FormatTime(int totalSeconds)
    {
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;
        return minutes + ":" + seconds.ToString("D2");
    }
}
