using System.Runtime.CompilerServices;

// Enum to represent different categories of commodities
public enum CommodityCategory
{
    Furniture,
    Grocery,
    Service
}

// Class representing a commodity/item
class Commodity
{
    // Category of the commodity
    public CommodityCategory Category { get; set; }

    // Name of the commodity
    public string? CommodityName { get; set; }

    // Quantity of the commodity
    public int Commodityquantity { get; set; }

    // Price of the commodity
    public double CommodityPrice { get; set; }

    // Constructor to initialize commodity details
    public Commodity(CommodityCategory catagory, string commodityName, int Commodityquantity, double CommodityPrice)
    {
        this.Category = catagory;
        this.CommodityName = commodityName;
        this.Commodityquantity = Commodityquantity;
        this.CommodityPrice = CommodityPrice;
    }
}

// Class responsible for tax setup and bill calculation
class PrepareBill
{
    // Readonly dictionary to store tax rates for each category
    readonly IDictionary<CommodityCategory, double> _taxRates = new Dictionary<CommodityCategory, double>();

    // Method to set tax rate for a commodity category
    public void SetTaxRate(CommodityCategory catagory, double taxRate)
    {
        if (_taxRates.ContainsKey(catagory))
        {
            System.Console.WriteLine("already exist");
        }
        else
        {
            _taxRates[catagory] = taxRate;
        }
    }

    // Method to calculate total bill amount
    public double CalculateBillAmount(IList<Commodity> items)
    {
        double tot = 0;

        // Loop through all commodities
        foreach (var i in items)
        {
            // Check if tax rate exists for the commodity category
            if (_taxRates.ContainsKey(i.Category))
            {
                // Add commodity price to total
                tot += i.CommodityPrice;
            }
            else
            {
                // Throw exception if tax rate is missing
                throw new ArgumentException("not exist");
            }
        }
        return tot;
    }
}

// Entry point of the application
public class Program
{
    public static void Main()
    {
        // Creating list of commodities
        var commodities = new List<Commodity>()
        {
            new Commodity(CommodityCategory.Furniture, "Bed", 2, 50000),
            new Commodity(CommodityCategory.Grocery, "Flour", 5, 80),
            new Commodity(CommodityCategory.Service, "Insurance", 8, 8500)
        };

        // Creating PrepareBill object
        var prepareBill = new PrepareBill();

        // Setting tax rates for each category
        prepareBill.SetTaxRate(CommodityCategory.Furniture, 18);
        prepareBill.SetTaxRate(CommodityCategory.Grocery, 5);
        prepareBill.SetTaxRate(CommodityCategory.Service, 12);

        // Calculating and printing total bill amount
        var bill = prepareBill.CalculateBillAmount(commodities);
        System.Console.WriteLine(bill);
    }
}
