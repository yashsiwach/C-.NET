/// <summary>
/// Simulates a bank account by processing a sequence of transactions.
/// Deposits are added to the balance, and withdrawals are allowed
/// only when sufficient balance is available. The final balance
/// after all transactions is returned.
/// </summary>
public class Program
{
    /// <summary>
    /// Calculates the final balance after applying all transactions
    /// on the initial balance.
/// </summary>
    public static int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        for (int i = 0; i < transactions.Length; i++)
        {
            if (transactions[i] >= 0)
            {
                balance += transactions[i];
            }
            else
            {
                int withdraw = -transactions[i];
                if (balance >= withdraw)
                    balance -= withdraw;
            }
        }

        return balance;
    }

    /// <summary>
    /// Program entry point. Reads input values, processes transactions,
    /// and prints the final account balance.
/// </summary>
    public static void Main(string[] args)
    {
        int initialBalance = int.Parse(Console.ReadLine()!);
        int n = int.Parse(Console.ReadLine()!);

        int[] transactions = new int[n];
        for (int i = 0; i < n; i++)
        {
            transactions[i] = int.Parse(Console.ReadLine()!);
        }

        int result = FinalBalance(initialBalance, transactions);
        Console.WriteLine(result);
    }
}
