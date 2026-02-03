using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Summary:
        // This program reads a log file (log.txt) that contains mixed log levels
        // such as INFO, WARN, and ERROR. It filters out only the lines that contain
        // the keyword "ERROR" and writes those lines into a new file (error.txt).

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
                // Filter condition: write only lines containing "ERROR"
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
