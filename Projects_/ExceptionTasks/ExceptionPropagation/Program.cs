using System;

class Controller
{
    static void Main()
    {
        // TODO:
        // Call Service method
        // Handle exception here
        try
        {
            Service.Process();
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
}

class Service
{
    public static void Process()
    {
        // TODO:
        // Call Repository method
        try
        {
            Repository.GetData();
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
        // Catch, log and rethrow exception
    }
}

class Repository
{
    public static void GetData()
    {
        // TODO:
        // Throw an exception here
        throw new ArgumentException("Error found");
    }
}