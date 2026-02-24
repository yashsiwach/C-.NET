public class OutOfStockException : Exception
{
    public OutOfStockException(string s) : base(s) { }
}
public class OrderAlreadyShippedException : Exception
{
    public OrderAlreadyShippedException(string s) : base(s) { }
}
public class CustomerBlacklistedException : Exception
{
    public CustomerBlacklistedException(string s) : base(s) { }
}
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

public class Customer
{
    public string Nam { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public Customer customer { get; set; }
    public List<OrderItem> OrderList = new();
    public DateTime OrderDate { get; set; }
    public string OrderStatus { get; set; }
}
public class OrderItem
{
    public Product product { get; set; }
    public int quantity { get; set; }
    public double TotalPrice()
    {
        return product.Price * quantity;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Product> ProData = new();
        List<Customer> CusData = new();
        List<Order> OrdData = new();
        Dictionary<Product, int> ProDict = new();

        ProData.Add(new Product { Id = 1, Name = "samosa", Price = 1200, Stock = 1 });
        ProData.Add(new Product { Id = 3, Name = "toffe", Price = 100, Stock = 70 });
        ProData.Add(new Product { Id = 4, Name = "biscuit", Price = 1300, Stock = 20 });
        ProData.Add(new Product { Id = 2, Name = "patis", Price = 10, Stock = 0 });

        CusData.Add(new Customer { Nam = "ram" });
        CusData.Add(new Customer { Nam = "dev" });
        CusData.Add(new Customer { Nam = "rohan" });
        CusData.Add(new Customer { Nam = "hell" });


        OrdData.Add(new Order
        {
            OrderId = 11,
            customer = CusData[0],
            OrderDate = DateTime.Now,
            OrderStatus = "Accpted",
            OrderList = new List<OrderItem>
            {
               new OrderItem{
                product=ProData[1],
                quantity=12
               },
               new OrderItem
               {
                   product=ProData[3],
                   quantity=2
               }
            }
        });
        OrdData.Add(new Order
        {
            OrderId = 12,
            customer = CusData[1],
            OrderDate = new DateTime(2025, 2, 2),
            OrderStatus = "Accpted",
            OrderList = new List<OrderItem>
            {
               new OrderItem{
                product=ProData[0],
                quantity=7
               }
            }
        });
        OrdData.Add(new Order
        {
            OrderId = 21,
            customer = CusData[3],
            OrderDate = DateTime.Now,
            OrderStatus = "Accpted",
            OrderList = new List<OrderItem>
            {
               new OrderItem{
                product=ProData[2],
                quantity=2
               },
               new OrderItem{
                product=ProData[3],
                quantity=1
               }
            }
        });
        var Last7 = OrdData.Where(x => { TimeSpan sp = DateTime.Now - x.OrderDate; return sp.TotalDays < 7; }).ToList();
        var totalrev = OrdData.Sum(x => x.OrderList.Sum(y => y.TotalPrice()));
        foreach (var i in OrdData)
        {
            foreach (var j in i.OrderList)
            {
                if (ProDict.ContainsKey(j.product))
                {
                    ProDict[j.product]++;
                }
                else
                {
                    ProDict[j.product] = 1;
                }
            }
        }
        var maxsold = ProDict.ToList().OrderByDescending(x => x.Value).First();

        Dictionary<Customer, int> PersonDict = new();
        foreach (var i in OrdData)
        {
            int sum = 0;
            foreach (var j in i.OrderList)
            {
                sum +=(int) j.TotalPrice();
            }
            if (PersonDict.ContainsKey(i.customer))
            {
                PersonDict[i.customer] += sum;
            }
            else
            {
                PersonDict[i.customer] = sum;
            }
        }
        var topspenders = PersonDict.OrderByDescending(x => x.Value).Take(2);
        var orderbystatus = OrdData.GroupBy(x => x.OrderStatus).ToDictionary(g => g.Key, g => g.ToList());
        var stockless10 = ProData.Where(x => x.Stock < 10).ToList();

        // Orders in last 7 days
        Console.WriteLine("Orders in Last 7 Days:");
        foreach (var o in Last7)
        {
            Console.WriteLine($"OrderId: {o.OrderId} | Customer: {o.customer.Nam} | Date: {o.OrderDate}");
        }

        // Total Revenue
        Console.WriteLine("\nTotal Revenue:");
        Console.WriteLine(totalrev);

        // Most Sold Product
        Console.WriteLine("\nMost Sold Product:");
        Console.WriteLine($"{maxsold.Key.Name} | Sold Count: {maxsold.Value}");

        // Top 2 Spenders
        Console.WriteLine("\nTop 2 Spenders:");
        foreach (var p in topspenders)
        {
            Console.WriteLine($"{p.Key.Nam} | Spent: {p.Value}");
        }

        // Orders Grouped By Status
        Console.WriteLine("\nOrders Grouped By Status:");
        foreach (var grp in orderbystatus)
        {
            Console.WriteLine($"\nStatus: {grp.Key}");
            foreach (var ord in grp.Value)
            {
                Console.WriteLine($"  OrderId: {ord.OrderId} | Customer: {ord.customer.Nam}");
            }
        }

        // Products with Stock < 10
        Console.WriteLine("\nProducts With Stock < 10:");
        foreach (var p in stockless10)
        {
            Console.WriteLine($"{p.Name} | Stock: {p.Stock}");
        }

    }
}