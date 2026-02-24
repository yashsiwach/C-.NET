public class Program
{
    public static void MakePayment(ref double walletBalance,double amount)
    {
        if (amount > 0 && amount <= walletBalance)
        {
            walletBalance-=amount;
            System.Console.WriteLine("successfull");
        }
    }
    public static void Main(string[] args)
    {
        double walletBalance=100;

        MakePayment(ref walletBalance,50);
        System.Console.WriteLine(walletBalance);
    }
}