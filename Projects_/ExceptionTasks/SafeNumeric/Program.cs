using System;

class InputHandler
{
    static void Main()
    {
        // TODO:
        // 1. Read input from user
        while(true){
        try{
            int number=int.Parse(Console.ReadLine()!);
            if(number is int)
                {
                    break;
                }
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }}
        // 2. Handle invalid numeric input
        // 3. Keep asking until valid number is entered
    }
}