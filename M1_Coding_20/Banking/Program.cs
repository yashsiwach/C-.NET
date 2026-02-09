public class BankAccount
{
    private double _balance{get;set;}
    public void Deposit(double amount)
    {
        if (amount <0)
        {
            System.Console.WriteLine("must be greater than 0");
        }
        else
        {
            _balance+=amount;
            
        }

    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance-=amount;
        }
        else
        {
            System.Console.WriteLine("withdraw error");
        }
    }
    public double finalBal()
    {
        return _balance;

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount=new BankAccount();
        bankAccount.Deposit(200);
        bankAccount.Deposit(-1);
        bankAccount.Withdraw(200);
        bankAccount.Withdraw(230);
        System.Console.WriteLine(bankAccount.finalBal());

    }
}