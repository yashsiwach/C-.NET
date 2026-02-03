using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
    

        string inputFile = "log.txt";
        string outputFile = "error.txt";

        // Check whether the input log file exists
        if (!File.Exists(inputFile))
        {
            Console.WriteLine("log.txt not found");
            return;
        }

        // Read all lines from the input log file
        string[] lines = File.ReadAllLines(inputFile);

        // Create or overwrite the output file and write only ERROR logs
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }

        // Indicate successful completion
        Console.WriteLine("ERROR logs extracted to error.txt");
    }
}
