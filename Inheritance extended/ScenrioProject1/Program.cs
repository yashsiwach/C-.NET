using System;
using System.Text;

public class Program
{
    /// <summary>
    /// This is the method to check the string with the rules and return the answer;
    /// </summary>
    public static void Main()
    {
        string? input = Console.ReadLine();
        string result = CleanseAndInvert(input);
        if (result.Length == 0)
        {
            System.Console.WriteLine("invalid");
        }
        else
        {
            System.Console.WriteLine("Generated String is: "+result);
        }
    }

    public static string CleanseAndInvert(string? input)
    {
        // Rule 1: null or length < 6
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return "";

        // Rule 2: only alphabets allowed
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                return "";
        }

        // Convert to lowercase
        StringBuilder sb = new StringBuilder(input.ToLower());

        // Remove characters whose ASCII value is even
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            if (((int)sb[i]) % 2 == 0)
            {
                sb.Remove(i, 1);
            }
        }

        // Reverse remaining characters
        string arr=sb.ToString();
        arr=new string(arr.Reverse().ToArray());

        sb = new StringBuilder(arr);

        // Uppercase characters at even positions (0-based)
        for (int i = 0; i < sb.Length; i++)
        {
            if (i % 2 == 0)
            {
                sb[i] = char.ToUpper(sb[i]);
            }
        }

        return sb.ToString();
    }
}
