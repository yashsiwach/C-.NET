public class EcommerceShop
{
    public string? UserName{get;set;}
    public double WalletBalance{get;set;}
    public double TotalPurchaseAmount{get;set;}
}
public class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string s) : base(s)
    {
        
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Program obj=new Program();
        var res=obj.MakePayment("test",1000,500);
        System.Console.WriteLine(res.UserName);
        var res1=obj.MakePayment("test2",200,50);
        System.Console.WriteLine(res1.UserName);
        var res2=obj.MakePayment("test3",400,450);
        System.Console.WriteLine(res2.UserName);
        
    }
    public EcommerceShop MakePayment(string name, double balance, double amount)
    {
        try{
        if (balance < amount)
        {
            throw new InsufficientWalletBalanceException("Balance is less than Amount");
        }
       
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
         return new EcommerceShop
        {
            UserName=name,
            WalletBalance=balance,
            TotalPurchaseAmount=amount
        };
    }
}