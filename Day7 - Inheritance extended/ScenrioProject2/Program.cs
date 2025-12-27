using System.Collections;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Project2;

public class Program
{
    /// <summary>
    /// Stores and manages account balance with deposit and withdrawal operations.
    /// </summary>
    public double Balance { get; set; }

    /// <summary>
    /// Initializes the account with an initial balance.
    /// </summary>
    public Program(double balance)
    {
        this.Balance = balance;
    }

    /// <summary>
    /// Accepts user input and performs deposit or withdrawal based on choice.
    /// </summary>
    public static void Main()
    {
        System.Console.WriteLine("Enter balance!");
        int bal = int.Parse(Console.ReadLine()!);
        Program obj = new Program(bal);

        System.Console.WriteLine("1. For deposit \n2.For Withdrawal");
        int choice = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Enter the amount!");

        if (choice == 1)
        {
            int num = int.Parse(Console.ReadLine()!);
            obj.Deposit(num);
        }
        else if (choice == 2)
        {
            int num = int.Parse(Console.ReadLine()!);
            obj.Withdraw(num);
        }
        else
        {
            System.Console.WriteLine("Enter the Valid choice ! Run Again");
        }
    }

    /// <summary>
    /// Deposits amount into balance after validation.
    /// </summary>
    public void Deposit(double num)
    {
        double prevBalance = this.Balance;
        UnitTest ut = new UnitTest();
        ut.Test_Deposit_NegativeAmount(num);
        this.Balance += num;
        ut.Deposit_ValidAmount(num, this.Balance, prevBalance);
    }

    /// <summary>
    /// Withdraws amount from balance after validation.
    /// </summary>
    public void Withdraw(double num)
    {
        double prevBalance = this.Balance;
        UnitTest ut = new UnitTest();
        ut.Test_Withdraw_InsufficientFunds(num, this.Balance);
        this.Balance -= num;
        ut.Test_Withdraw_ValidAmount(num, this.Balance, prevBalance);
    }
}
