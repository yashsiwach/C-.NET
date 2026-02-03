using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        File.WriteAllText("data.txt", "ok");
        string filePath = "data.txt";

        // TODO:
        // 1. Read file content
        try
        {
            // string content="";
            using (StreamReader sr = new StreamReader(filePath))
            {
                string temp = sr.ReadToEnd();
                System.Console.WriteLine(temp);
            }

        }
        catch (FileNotFoundException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            System.Console.WriteLine(ex.Message);
            
        }

        // 2. Handle FileNotFoundException

        // 3. Handle UnauthorizedAccessException

        // 4. Ensure resource is closed properly
    }
}