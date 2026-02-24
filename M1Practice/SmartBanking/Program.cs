public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string s) : base(s) { }
}
public class MinimumBalanceException : Exception
{
    public MinimumBalanceException(string s) : base(s) { }
}
public class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string s) : base(s) { }
}
public abstract class BankAccount
{
    public int AccountNumber { get; set; }
    public string CustomerName { get; set; }
    public double balance { get; set; }
    public void Deposit(double amount)
    {
        balance += amount;
    }
    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Not enogh money");
        }
        balance -= amount;
        Console.WriteLine("successful");
    }
    public abstract void CalculateInterest();
}
public class SavingsAccount : BankAccount
{
    public void Withdraw(double amount)
    {
        if ( balance-amount<1000)
        {
            throw new InsufficientBalanceException("Not enogh money");
        }
        balance -= amount;
        Console.WriteLine("successful");
    }
    public override void CalculateInterest() { }

}
public class CurrentAccount : BankAccount
{
    public override void CalculateInterest() { }

}
public class LoanAccount : BankAccount
{
    public void Deposit(double amount)
    {
        throw new InvalidTransactionException("can't deposit in the loan account");
    }
    public override void CalculateInterest() { }

}
public class Program
{
    public static List<BankAccount> data = new();
    public static void Main(string[] args)
    {
        data.Add(new SavingsAccount { AccountNumber = 1, CustomerName = "test1", balance = 3000 });
        data.Add(new LoanAccount { AccountNumber = 2, CustomerName = "Rest2", balance = 4020 });
        data.Add(new LoanAccount { AccountNumber = 3, CustomerName = "test3", balance = 6200 });
        data.Add(new SavingsAccount { AccountNumber = 4, CustomerName = "test4", balance = 2050 });
        data.Add(new CurrentAccount { AccountNumber = 5, CustomerName = "test5", balance = 4030 });
        var AccOver5k = data.Where(x => x.balance >= 5000).ToList();
        var total = data.Sum(s => s.balance);
        var top3 = data.OrderByDescending(x => x.balance).Take(3);
        var AccWise = data.GroupBy(x => x.GetType()).ToDictionary(g => g.Key, g => g.ToList());
        var NameR = data.Where(x => x.CustomerName.StartsWith('R')).ToList();
        // Accounts with balance >= 5000
        Console.WriteLine("Accounts with Balance >= 5000:");
        foreach (var acc in AccOver5k)
        {
            Console.WriteLine($"{acc.GetType().Name} | {acc.AccountNumber} | {acc.CustomerName} | {acc.balance}");
        }

        Console.WriteLine("\nTotal Balance:");
        Console.WriteLine(total);

        // Top 3 Accounts by Balance
        Console.WriteLine("\nTop 3 Accounts:");
        foreach (var acc in top3)
        {
            Console.WriteLine($"{acc.GetType().Name} | {acc.AccountNumber} | {acc.CustomerName} | {acc.balance}");
        }

        // Grouped by Account Type
        Console.WriteLine("\nGrouped By Account Type:");
        foreach (var group in AccWise)
        {
            Console.WriteLine($"\nType: {group.Key.Name}");
            foreach (var acc in group.Value)
            {
                Console.WriteLine($"{acc.AccountNumber} | {acc.CustomerName} | {acc.balance}");
            }
        }

        // Customer Name Starts With 'R'
        Console.WriteLine("\nCustomer Name Starts With R:");
        foreach (var acc in NameR)
        {
            Console.WriteLine($"{acc.GetType().Name} | {acc.AccountNumber} | {acc.CustomerName} | {acc.balance}");
        }

    }
}
