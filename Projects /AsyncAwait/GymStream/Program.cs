using System.Runtime.InteropServices;

public class InvalidTierException : Exception
{
    public InvalidTierException(string s) : base(s) { }
}
public class Membership
{
    public string Tier { get; set; }
    public int DurationInMonths { get; set; }
    public double BasePricePerMonth { get; set; }
    public bool ValidateEnrollment()
    {
        if (!(Tier == "Basic" || Tier == "Premium" || Tier == "Elite"))
        {
            throw new InvalidTierException("invalid Tier");
        }
        if (DurationInMonths < 0)
        {
            throw new ArgumentException("Must be greater than 0");
        }
        return true;
    }
    public double CalculateTotalBill()
    {
        double fair = (DurationInMonths * BasePricePerMonth);
        if (Tier == "Basic") fair = fair - (fair * 0.02);
        else if (Tier == "Premium") fair = fair - (fair * 0.07);
        else fair = fair - (fair * 0.12);
        return fair;
    }

}

public class Program
{
    public static void Main()
    {
        Membership obj = new Membership();
        System.Console.WriteLine("enter the tier");
        obj.Tier = Console.ReadLine();
        System.Console.WriteLine("enter duration");
        obj.DurationInMonths = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine("Price");
        obj.BasePricePerMonth = double.Parse(Console.ReadLine()!);
        try
        {
            obj.ValidateEnrollment();
            System.Console.WriteLine("successfull");
            System.Console.WriteLine($"{    obj.CalculateTotalBill():F2}");


        }
        catch (InvalidTierException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            System.Console.WriteLine(e.Message);
        }



    }
}