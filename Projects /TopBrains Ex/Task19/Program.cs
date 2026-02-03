using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = "programming";
        char target = 'g';

        Console.WriteLine(CountChar(input, target));
    }

    // Counts how many times a given character appears in a string.
    static int CountChar(string s, char c)
    {
        int count = 0;

        foreach (char ch in s)
            if (ch == c) count++;

        return count;
    }
}
