using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] data = Regex.Split(input, "[^A-Za-z]+");

        Array.Sort(data, (a, b) => b.CompareTo(a));

        Console.WriteLine(data[0]);
    }
}