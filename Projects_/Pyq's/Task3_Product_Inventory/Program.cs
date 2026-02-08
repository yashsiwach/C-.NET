using System.Linq;

/// <summary>
/// Represents a product with basic inventory details.
/// </summary>
public interface IProduct
{

    string Name { get; set; }

    string Category { get; set; }

    int Stock { get; set; }

    int Price { get; set; }
}

/// <summary>
/// Defines operations supported by an inventory system.
/// </summary>
public interface IInventory
{
    /// <summary>
    /// Adds a product to the inventory.
    /// </summary>
    void AddProduct(IProduct product);

    /// <summary>
    /// Removes a product from the inventory.
    /// </summary>
    void RemoveProduct(IProduct product);

    /// <summary>
    /// Calculates total inventory value (Price × Stock).
    /// </summary>
    int CalculateTotalValue();

    /// <summary>
    /// Gets all products belonging to a specific category.
    /// </summary>
    List<IProduct> GetProductsByCategory(string Category);

    /// <summary>
    /// Gets product count grouped by category.
    /// </summary>
    List<Tuple<string, int>> GetProductsByCategoryCount();

    /// <summary>
    /// Searches products by name.
    /// </summary>
    List<IProduct> SearchProductsByName(string name);

    /// <summary>
    /// Gets all products grouped by category.
    /// </summary>
    List<Tuple<string, List<IProduct>>> GetAllProductsByCategory();
}

/// <summary>
/// Concrete implementation of IProduct.
/// </summary>
public class Product : IProduct
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }
}

/// <summary>
/// Implements inventory operations using LINQ.
/// </summary>
public class Inventory : IInventory
{
    /// <summary>
    /// Internal list storing all products.
    /// </summary>
    private List<IProduct> _products = new List<IProduct>();

    /// <summary>
    /// Adds a product to inventory.
    /// </summary>
    public void AddProduct(IProduct product)
    {
        _products.Add(product);
    }

    /// <summary>
    /// Removes a product from inventory.
    /// </summary>
    public void RemoveProduct(IProduct product)
    {
        _products.Remove(product);
    }

    /// <summary>
    /// Calculates total value of inventory.
    /// </summary>
    public int CalculateTotalValue()
    {
        return _products.Sum(x => x.Price * x.Stock);
    }

    /// <summary>
    /// Returns products filtered by category.
    /// </summary>
    public List<IProduct> GetProductsByCategory(string Category)
    {
        return _products.Where(x => x.Category == Category).ToList();
    }

    /// <summary>
    /// Returns category-wise product count.
    /// </summary>
    public List<Tuple<string, int>> GetProductsByCategoryCount()
    {
        return _products
            .GroupBy(e => e.Category)
            .Select(x => new Tuple<string, int>(x.Key, x.Count()))
            .ToList();
    }

    /// <summary>
    /// Searches products whose name contains the given string.
    /// </summary>
    public List<IProduct> SearchProductsByName(string name)
    {
        return _products.Where(x => x.Name.Contains(name)).ToList();
    }

    /// <summary>
    /// Groups products by category and returns category-wise lists.
    /// </summary>
    public List<Tuple<string, List<IProduct>>> GetAllProductsByCategory()
    {
        return _products
            .GroupBy(e => e.Category)
            .Select(x => new Tuple<string, List<IProduct>>(x.Key, x.ToList()))
            .ToList();
    }
}

/// <summary>
/// Entry point of the application.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method demonstrating inventory operations.
    /// </summary>
    public static void Main(string[] args)
    {
        Inventory obj = new Inventory();

        obj.AddProduct(new Product
        {
            Name = "test1",
            Category = "GroupA",
            Stock = 10,
            Price = 100
        });

        obj.AddProduct(new Product
        {
            Name = "test2",
            Category = "GroupB",
            Stock = 10,
            Price = 300
        });

        obj.AddProduct(new Product
        {
            Name = "test3",
            Category = "GroupA",
            Stock = 10,
            Price = 100
        });

        obj.AddProduct(new Product
        {
            Name = "test4",
            Category = "GroupC",
            Stock = 10,
            Price = 40
        });

        int totalValue = obj.CalculateTotalValue();
        System.Console.WriteLine(totalValue);

        var CategoryWise = obj.GetProductsByCategory("GroupA");
        CategoryWise.ForEach(x =>
            System.Console.WriteLine($"{x.Name} - {x.Category} - {x.Stock} - {x.Price}")
        );

        var CategoryCount = obj.GetProductsByCategoryCount();
        CategoryCount.ForEach(x =>
            System.Console.WriteLine($"{x.Item1} - {x.Item2}")
        );

        var SearchByName = obj.SearchProductsByName("t3");
        SearchByName.ForEach(x =>
            System.Console.WriteLine($"{x.Name} - {x.Category} - {x.Stock} - {x.Price}")
        );

        var GetAll = obj.GetAllProductsByCategory();
        GetAll.ForEach(x =>
        {
            System.Console.WriteLine(x.Item1);
            x.Item2.ForEach(y =>
                System.Console.WriteLine($"{y.Name} - {y.Category} - {y.Stock} - {y.Price}")
            );
        });
    }
}
