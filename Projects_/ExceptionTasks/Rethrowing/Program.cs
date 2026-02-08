using System;

class ExceptionRethrow
{
    static void Main()
    {
        try
        {
            ProcessData();
        }
        catch (Exception e)
        {
            Console.WriteLine("Final handler: " + e.Message);
        }
    }

    static void ProcessData()
    {
        try
        {
            int.Parse("ABC");
        }
        catch (Exception e)
        {
            Console.WriteLine("Logging: " + e.Message);
            throw;
        }
    }
}




