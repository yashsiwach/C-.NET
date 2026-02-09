public abstract class DiscountPolicy
{
    public abstract double GetFinalAmount(double amount);
}
public class FestivalDiscount : DiscountPolicy
{
    public override double GetFinalAmount(double amount)
    {
        return amount>=5000?amount-amount*0.10:amount;
    }
}
public class MemberDiscount : DiscountPolicy
{
    public override double GetFinalAmount(double amount)
    {
        return amount>=2000?amount-300:amount;
    }
}
public class Program
{
    public static void Main()
    {
        string? DiscountType=Console.ReadLine();
        int amount=int.Parse(Console.ReadLine()!);
        if (DiscountType == "Festival")
        {
            var obj=new FestivalDiscount();
            System.Console.WriteLine( obj.GetFinalAmount(amount));
        }
        else
        {
            var obj=new MemberDiscount();
            System.Console.WriteLine( obj.GetFinalAmount(amount));
        }
    }
}