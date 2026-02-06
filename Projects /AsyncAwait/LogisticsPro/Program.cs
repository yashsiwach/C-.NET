using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Shipment code");
        string? shipmentCode=Console.ReadLine();
        var obj=new ShipmentDetails();
        obj.ShipmentCode=shipmentCode;
        if (obj.ValidateShipmentCode())
        {
            System.Console.WriteLine("Enter transport mode");
            obj.TransportMode=Console.ReadLine();
            System.Console.WriteLine("weight");
            obj.Weight=double.Parse(Console.ReadLine()!);
            System.Console.WriteLine("storage");
            obj.StorageDays=int.Parse(Console.ReadLine()!);
            System.Console.WriteLine( "Total Cost: "+obj.CalculateTotalCost());
        }
        else
        {
            System.Console.WriteLine("Invalid Code");
        }
    }
}
public class Shipment
{
    public string? ShipmentCode{get;set;}
    public string? TransportMode{get;set;}
    public double Weight{get;set;}
    public int StorageDays{get;set;}
}
public class ShipmentDetails:Shipment
{
    public bool  ValidateShipmentCode()
    {
        return Regex.IsMatch(ShipmentCode!,@"^GC#[0-9]{4}$");
        
    }
    public double CalculateTotalCost()
    {
        double ratePerKg=0;
        if(TransportMode=="Sea")ratePerKg=15;
        else if(TransportMode=="Air")ratePerKg=50;
        else ratePerKg=25;
        return Math.Round((Weight*ratePerKg)+Math.Sqrt(StorageDays),2);
    }
}