using System;
public class LessThanZeroException : Exception
{
    public LessThanZeroException(string s) : base(s) { }
}
public class AmountGreaterThanBalance : Exception
{
    public AmountGreaterThanBalance(string s) : base(s) { }
}
public class BankAccount
{
    public static void Main()
    {
        int balance = 10000;

        Console.WriteLine("Enter withdrawal amount:");
        int amount = int.Parse(Console.ReadLine());

        // TODO:
        // 1. Throw exception if amount <= 0
        try
        {
            if (amount <= 0)
            {
                throw new LessThanZeroException("Amount must be Greater than 0!");
            }
            // 2. Throw exception if amount > balance
            if (amount > balance)
            {
                throw new AmountGreaterThanBalance("Amount is greater the balance");
            }
            // 3. Deduct amount if valid
            balance -= amount;
            System.Console.WriteLine("Success");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        finally
        {
            System.Console.WriteLine("transaction Completed !");
        }


        // 4. Use finally block to log transaction
    }
}