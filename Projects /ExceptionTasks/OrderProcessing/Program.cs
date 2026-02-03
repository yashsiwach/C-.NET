using System;

class OrderProcessor
{
    static void Main()
    {
        int[] orders = { 101, -1, 103 };

        // TODO:
        // 1. Process each order
        for(int i = 0; i < orders.Length; i++)
        {
            try
            {
                if (orders[i] <= 0)
                {
                    throw new ArgumentException("Invalid");
                }
                
                System.Console.WriteLine(orders[i]);
         }
            catch(ArgumentException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        // 2. Throw exception for invalid order ID
        // 3. Ensure one failure does not stop processing
    }
}