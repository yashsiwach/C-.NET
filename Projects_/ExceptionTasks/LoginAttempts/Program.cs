using System;
public class LimitReached : Exception
{
    public LimitReached(string s) : base(s) { }
}

class LoginSystem
{
    static void Main()
    {
        int attempts = 0;
        string password = "admin";
        // TODO:
        // 1. Allow only 3 login attempts
        try
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (password != input)
                {
                    attempts++;
                    System.Console.WriteLine("try again");
                }
                else
                {
                    attempts = 0;
                    System.Console.WriteLine("Login Success!");
                    break;
                }
                if (attempts >= 3)
                {
                    throw new LimitReached("3 Attempted Made GOOD BY!");
        
                }
            }
        }
        catch (LimitReached e)
        {
            System.Console.WriteLine(e.Message);
        }
        // 2. Create and throw custom exception after limit
        // 3. Handle exception and terminate application
    }
}