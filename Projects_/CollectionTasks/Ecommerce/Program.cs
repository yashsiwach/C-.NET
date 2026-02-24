public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        if (!_products.Any(x=>x.Id==product.Id)&&(product.Price>0)&&(!string.IsNullOrEmpty(product.Name)))
        {
            _products.Add(product);
        }
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(x=>predicate(x)).ToList();

    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        
        // Return sum of all product prices
        return _products.Sum(x=>x.Price);
    }
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string Brand { get; set; }
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        _product=product;
        if (discountPercentage >= 0 && discountPercentage <= 100)
        {
            _discountPercentage=discountPercentage;
        }
        else
        {
            Console.WriteLine("error discount");
        }
        // Discount must be between 0 and 100
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);
    public override string ToString()
    {
        return "Discount is :"+DiscountedPrice;
    }
    
    // TODO: Override ToString to show discount details
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        foreach(var i in products)
        {
            Console.WriteLine(i.Name+" "+i.Price);
        }
        // b) Find the most expensive product
        var temp=products.Max(x=>x.Price);
        Console.WriteLine(temp);
        // c) Group products by category
        var gr=products.GroupBy(x=>x.Category);
        foreach(var i in gr)
        {
            Console.WriteLine(i.Key);
            foreach(var j in i)
            {
                Console.Write(j+" ");
                Console.WriteLine();
            }
        }
        // d) Apply 10% discount to Electronics over $500
        var las=products.Where(x=>x.Price>500&&x.Category==Category.Electronics).Select(y=>new DiscountedProduct<T>(y,10)).ToList();
        foreach( var i in las)
        {
            Console.Write(i+" ");
            Console.WriteLine();
        }

    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        try{
        // Apply priceAdjuster to each product
        products.Select(x=>priceAdjuster(x));
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Handle exceptions gracefully
    }
}

// 5. TEST SCENARIO: Your tasks:
class Program
{
    static void Main(string[] args)
    {
        var repo = new ProductRepository<ElectronicProduct>();

        var p1 = new ElectronicProduct { Id = 1, Name = "Laptop", Price = 800, Brand = "Dell", WarrantyMonths = 24 };
        var p2 = new ElectronicProduct { Id = 2, Name = "Phone", Price = 1200, Brand = "Apple", WarrantyMonths = 12 };
        var p3 = new ElectronicProduct { Id = 3, Name = "Headphones", Price = 150, Brand = "Sony", WarrantyMonths = 18 };
        var p4 = new ElectronicProduct { Id = 4, Name = "Monitor", Price = 600, Brand = "Samsung", WarrantyMonths = 36 };
        var p5 = new ElectronicProduct { Id = 5, Name = "Mouse", Price = 40, Brand = "Logitech", WarrantyMonths = 12 };

        repo.AddProduct(p1);
        repo.AddProduct(p2);
        repo.AddProduct(p3);
        repo.AddProduct(p4);
        repo.AddProduct(p5);

        Console.WriteLine("Products by brand Apple:");
        var appleProducts = repo.FindProducts(p => p.Brand == "Apple");
        foreach (var p in appleProducts)
            Console.WriteLine($"{p.Name} - {p.Price}");

        Console.WriteLine();
        Console.WriteLine("Total inventory value:");
        Console.WriteLine(repo.CalculateTotalValue());

        Console.WriteLine();
        Console.WriteLine("Applying discounts:");
        var discountedLaptop = new DiscountedProduct<ElectronicProduct>(p1, 10);
        var discountedPhone = new DiscountedProduct<ElectronicProduct>(p2, 15);
        Console.WriteLine(discountedLaptop);
        Console.WriteLine(discountedPhone);

        Console.WriteLine();
        var manager = new InventoryManager();

        Console.WriteLine("Processing inventory:");
        manager.ProcessProducts(repo.FindProducts(_ => true));

        Console.WriteLine();
        Console.WriteLine("Bulk price update (+5%):");
        manager.UpdatePrices(
            new List<ElectronicProduct> { p1, p2, p3, p4, p5 },
            p => p.Price * 1.05m
        );

        Console.WriteLine();
        Console.WriteLine("Inventory after price update:");
        foreach (var p in repo.FindProducts(_ => true))
            Console.WriteLine($"{p.Name} - {p.Price}");
    }
}