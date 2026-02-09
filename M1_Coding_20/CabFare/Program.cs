public class Cab
{
    public virtual double CalculateFare(int KM)
    {
        return 0;
    }
}
public class Mini : Cab
{
    public override double CalculateFare(int KM)
    {
        return KM*12;
    }
}

public class Sedan : Cab
{
    public override double CalculateFare(int KM)
    {
        return KM*15+50;
    }
}
public class SUV : Cab
{
    public override double CalculateFare(int KM)
    {
        return KM*18+100;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        string? Cabtype=Console.ReadLine();
        int km=int.Parse(Console.ReadLine()!);
        if (Cabtype == "Mini")
        {
            var obj=new Mini();
            System.Console.WriteLine( obj.CalculateFare(km));
        }
        else if (Cabtype == "Sedan")
        {
            var obj=new Mini();
            System.Console.WriteLine( obj.CalculateFare(km));
        }
        else        
        {
            var obj=new Mini();
            System.Console.WriteLine( obj.CalculateFare(km));
        }
    }
}
