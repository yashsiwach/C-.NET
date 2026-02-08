using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] tokens = { "10", "abc", "20", "9999999999", "-5", "3.14" };

        // Compute the sum of valid 32-bit integers
        int result = SumParsedIntegers(tokens);

        // Print the result
        Console.WriteLine(result);
    }

    // Summary:
    // This method iterates over an array of strings and attempts to parse each
    // string into a 32-bit integer using int.TryParse. Only successfully parsed
    static int SumParsedIntegers(string[] tokens)
    {
        int sum = 0; // Stores the sum of valid integers

        // Iterate through each string in the array
        foreach (string token in tokens)
        {
            int value;

            // Try to parse the string as a 32-bit integer
            if (int.TryParse(token, out value))
            {
                // Add to sum only if parsing succeeds
                sum += value;
            }
        }

        // Return the final sum
        return sum;
    }
}
